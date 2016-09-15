using System;
using System.Windows.Forms;
using KrKrSceneManager;

namespace ScnEditorGUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            MessageBox.Show("This program is released on an as-is basis. It is not guaranteed to work.\nThis program was based on the library \"KrKrSceneManager.dll\" by marcussacana, an open-source project designed to allow the editing of SCN (with sig PSB or MDF) or TJS2 Files (with sig TJS2100), which can be found on GitHub.\n\nHow to use:\n*Use the file menu to open or save the file.\n*Search for or select the string in the listing and edit in the text box below.\n*Press the SAVE button to update the string.\n\nThis program is unstable!", "Achtung!");
        }

        private void openscnFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.FileName = "";
            fd.Filter = "KiriKiri Compiled Files | *.scn; *.psb|Pack of Resources | *.pimg";
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
                OpenFile(fd.FileName);
        }

        private void saveCurrentFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ResourceMode)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "";
                save.Filter = "Pack of Resources | *.pimg";
                DialogResult dr = save.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    FileEntry[] Images = new FileEntry[PRM.EntryCount];
                    for (int i = 0; i < Images.Length; i++)
                    {
                        Images[i] = new FileEntry();
                        Images[i].Data = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + i + ".res");
                    }
                    byte[] result = PRM.Export(Images);
                    System.IO.File.WriteAllBytes(save.FileName, result);
                }
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "";
                save.Filter = "KiriKiri Compiled Files | *.scn; *.psb|Pack of Resources | *.pimg";
                DialogResult dr = save.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    for (int i = 0; i < SCN.Strings.Length; i++)
                    {
                        SCN.Strings[i] = listBox_strings.Items[i].ToString();
                    }
                    dr = MessageBox.Show("Would you like to compress the script? (Recommended)\n\nDoes not work with old games.", "ScnEditorGUI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    SCN.CompressPackget = dr == DialogResult.Yes;
                    SCN.CompressionLevel = CompressionLevel.Z_BEST_COMPRESSION; //opitional
                    byte[] outfile = SCN.Export();
                    System.IO.File.WriteAllBytes(save.FileName, outfile);

                }
            }
            MessageBox.Show("File Saved.");
        }

        private void decompressImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.FileName = "";
            fd.Filter = "All Files | *.*";
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                byte[] input = System.IO.File.ReadAllBytes(fd.FileName);
                byte[] output = HuffmanTool.DecompressBitmap(input);
                string fname = System.IO.Path.GetFileNameWithoutExtension(fd.FileName);
                System.IO.File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + fname + "_decompressed.raw", output);
                MessageBox.Show("This Resouce is Writed to Dracu-Riot, you need discovery resolution and add a bmp header manually and the unknown resolution.\n\n(Probabbly use RGBQuad)", "ScnEditorGUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void compressImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.FileName = "";
            fd.Filter = "All Files | *.*";
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                byte[] input = System.IO.File.ReadAllBytes(fd.FileName);
                byte[] output = HuffmanTool.CompressBitmap(input, true);
                string fname = System.IO.Path.GetFileNameWithoutExtension(fd.FileName);
                System.IO.File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + fname + "_compressed.res", output);
                MessageBox.Show("Compressed to Tool Dir.", "ScnEditorGUI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void tryRecoveryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All PSB Files|*.psb;*.scn;*.pimg";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    byte[] data = System.IO.File.ReadAllBytes(ofd.FileName);
                    data = (new PSBStringManager()).TryRecovery(data);
                    System.IO.File.WriteAllBytes(ofd.FileName, data);
                    MessageBox.Show("Packget Offset's Updated", "ScnEditorGUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed To Recovery:\n" + ex.Message, "ScnEditorGUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        int DataSegment = 0;
        Sector[] Segments = new Sector[0];
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.FileName = "";
            fd.Filter = "KiriKiri TJS Compiled Files | *.tjs";
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                byte[] Data = System.IO.File.ReadAllBytes(fd.FileName);
                Segments = TJS2SManager.Split(Data);
                for (int i = 0; i < Segments.Length; i++)
                    if (Segments[i].SectorType == SectorType.DATA)
                        DataSegment = i;
                string[] Strings = TJS2SManager.GetContent(Segments[DataSegment]);
                listBox_strings.Items.Clear();
                foreach (string str in Strings)
                    listBox_strings.Items.Add(str);
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.FileName = "";
            fd.Filter = "KiriKiri TJS Compiled Files | *.tjs";
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string[] NewString = new string[listBox_strings.Items.Count];
                for (int i = 0; i < NewString.Length; i++)
                    NewString[i] = listBox_strings.Items[i].ToString();

                Sector DataSector = Segments[DataSegment];
                TJS2SManager.SetContent(ref DataSector, NewString);
                Segments[DataSegment] = DataSector;

                byte[] NewTJS2 = TJS2SManager.Merge(Segments);

                System.IO.File.WriteAllBytes(fd.FileName, NewTJS2);
                MessageBox.Show("File Saved.");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Advanced SCN Editor v0.1a by Rebecca Miyamoto.\nBased on SCN Editor by marcussacana, found on github.", "Advanced SCN Editor");
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            String[] fileStrings = new String[listBox_strings.Items.Count];
            int stringIndex = 0;
            foreach (string str in listBox_strings.Items)
            {
                fileStrings[stringIndex] = str;
                stringIndex++;
            }
            int stringArrayIndex = 0;
            foreach (string str in fileStrings)
            {
                if (str.Contains(textbox_search.Text))
                {
                    listBox_strings.SelectedIndex = stringArrayIndex;
                }
                stringArrayIndex++;
            }
        }

        private void button_commit_Click(object sender, EventArgs e)
        {
            listBox_strings.Items[listBox_strings.SelectedIndex] = textbox_editing.Text;
        }

        bool ResourceMode = false;
        PSBResourceManager PRM = new PSBResourceManager();
        public PSBStringManager SCN = new PSBStringManager();
        private void OpenFile(string fname)
        {
            if (fname.EndsWith(".pimg"))
            {
                ResourceMode = true;
                FileEntry[] Rst = PRM.Import(System.IO.File.ReadAllBytes(fname));
                for (int i = 0; i < Rst.Length; i++)
                    System.IO.File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + i + ".res", Rst[i].Data);
                MessageBox.Show("Resources Extracted in the Program Directory...", "Resource Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ResourceMode = false;
                listBox_strings.Items.Clear();
                SCN.Import(System.IO.File.ReadAllBytes(fname));
                foreach (string str in SCN.Strings)
                {
                    listBox_strings.Items.Add(str);
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textbox_stringID.Text = listBox_strings.SelectedIndex.ToString();
                textbox_editing.Text = listBox_strings.Items[listBox_strings.SelectedIndex].ToString();
            }
            catch { }
        }
    }
}
