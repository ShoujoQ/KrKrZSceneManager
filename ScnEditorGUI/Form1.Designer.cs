namespace ScnEditorGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_strings = new System.Windows.Forms.ListBox();
            this.textbox_editing = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_OpenSCNFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_SaveSCNFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Huffman = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Huffman_DecompressImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Huffman_CompressImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_TryRecovery = new System.Windows.Forms.ToolStripMenuItem();
            this.tJS2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_TJS2_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_TJS2_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_save = new System.Windows.Forms.Button();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label_editinstruction = new System.Windows.Forms.Label();
            this.label_searchinstruction = new System.Windows.Forms.Label();
            this.label_selectedstringID = new System.Windows.Forms.Label();
            this.textbox_stringID = new System.Windows.Forms.TextBox();
            this.label_listbox = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_strings
            // 
            this.listBox_strings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_strings.FormattingEnabled = true;
            this.listBox_strings.Location = new System.Drawing.Point(12, 81);
            this.listBox_strings.MaximumSize = new System.Drawing.Size(435, 230);
            this.listBox_strings.MinimumSize = new System.Drawing.Size(435, 230);
            this.listBox_strings.Name = "listBox_strings";
            this.listBox_strings.ScrollAlwaysVisible = true;
            this.listBox_strings.Size = new System.Drawing.Size(435, 225);
            this.listBox_strings.TabIndex = 7;
            this.listBox_strings.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textbox_editing
            // 
            this.textbox_editing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_editing.Location = new System.Drawing.Point(12, 330);
            this.textbox_editing.Name = "textbox_editing";
            this.textbox_editing.Size = new System.Drawing.Size(369, 22);
            this.textbox_editing.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_OpenSCNFile,
            this.toolStripMenuItem_SaveSCNFile,
            this.toolStripMenuItem_Huffman,
            this.toolStripMenuItem_TryRecovery,
            this.tJS2ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem_OpenSCNFile
            // 
            this.toolStripMenuItem_OpenSCNFile.Name = "toolStripMenuItem_OpenSCNFile";
            this.toolStripMenuItem_OpenSCNFile.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem_OpenSCNFile.Text = "Open .scn file";
            this.toolStripMenuItem_OpenSCNFile.Click += new System.EventHandler(this.openscnFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_SaveSCNFile
            // 
            this.toolStripMenuItem_SaveSCNFile.Name = "toolStripMenuItem_SaveSCNFile";
            this.toolStripMenuItem_SaveSCNFile.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem_SaveSCNFile.Text = "Save .scn file";
            this.toolStripMenuItem_SaveSCNFile.Click += new System.EventHandler(this.saveCurrentFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_Huffman
            // 
            this.toolStripMenuItem_Huffman.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Huffman_DecompressImage,
            this.toolStripMenuItem_Huffman_CompressImage});
            this.toolStripMenuItem_Huffman.Name = "toolStripMenuItem_Huffman";
            this.toolStripMenuItem_Huffman.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem_Huffman.Text = "Huffman";
            // 
            // toolStripMenuItem_Huffman_DecompressImage
            // 
            this.toolStripMenuItem_Huffman_DecompressImage.Name = "toolStripMenuItem_Huffman_DecompressImage";
            this.toolStripMenuItem_Huffman_DecompressImage.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuItem_Huffman_DecompressImage.Text = "Decompress Image";
            this.toolStripMenuItem_Huffman_DecompressImage.Click += new System.EventHandler(this.decompressImageToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem_Huffman_CompressImage
            // 
            this.toolStripMenuItem_Huffman_CompressImage.Name = "toolStripMenuItem_Huffman_CompressImage";
            this.toolStripMenuItem_Huffman_CompressImage.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuItem_Huffman_CompressImage.Text = "Compress Image";
            this.toolStripMenuItem_Huffman_CompressImage.Click += new System.EventHandler(this.compressImageToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem_TryRecovery
            // 
            this.toolStripMenuItem_TryRecovery.Name = "toolStripMenuItem_TryRecovery";
            this.toolStripMenuItem_TryRecovery.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem_TryRecovery.Text = "Try Recovery";
            this.toolStripMenuItem_TryRecovery.Click += new System.EventHandler(this.tryRecoveryToolStripMenuItem1_Click);
            // 
            // tJS2ToolStripMenuItem
            // 
            this.tJS2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_TJS2_Open,
            this.toolStripMenuItem_TJS2_Save});
            this.tJS2ToolStripMenuItem.Name = "tJS2ToolStripMenuItem";
            this.tJS2ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.tJS2ToolStripMenuItem.Text = "TJS2";
            // 
            // toolStripMenuItem_TJS2_Open
            // 
            this.toolStripMenuItem_TJS2_Open.Name = "toolStripMenuItem_TJS2_Open";
            this.toolStripMenuItem_TJS2_Open.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem_TJS2_Open.Text = "Open";
            this.toolStripMenuItem_TJS2_Open.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem_TJS2_Save
            // 
            this.toolStripMenuItem_TJS2_Save.Name = "toolStripMenuItem_TJS2_Save";
            this.toolStripMenuItem_TJS2_Save.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem_TJS2_Save.Text = "Save";
            this.toolStripMenuItem_TJS2_Save.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(387, 330);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(60, 22);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_commit_Click);
            // 
            // textbox_search
            // 
            this.textbox_search.Location = new System.Drawing.Point(12, 40);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(311, 22);
            this.textbox_search.TabIndex = 2;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(329, 40);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(60, 22);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_editinstruction
            // 
            this.label_editinstruction.AutoSize = true;
            this.label_editinstruction.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_editinstruction.Location = new System.Drawing.Point(9, 314);
            this.label_editinstruction.Name = "label_editinstruction";
            this.label_editinstruction.Size = new System.Drawing.Size(154, 13);
            this.label_editinstruction.TabIndex = 8;
            this.label_editinstruction.Text = "Edit the selected string here:";
            // 
            // label_searchinstruction
            // 
            this.label_searchinstruction.AutoSize = true;
            this.label_searchinstruction.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_searchinstruction.Location = new System.Drawing.Point(9, 24);
            this.label_searchinstruction.Name = "label_searchinstruction";
            this.label_searchinstruction.Size = new System.Drawing.Size(168, 13);
            this.label_searchinstruction.TabIndex = 1;
            this.label_searchinstruction.Text = "Search for the following string:";
            // 
            // label_selectedstringID
            // 
            this.label_selectedstringID.AutoSize = true;
            this.label_selectedstringID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectedstringID.Location = new System.Drawing.Point(392, 24);
            this.label_selectedstringID.Name = "label_selectedstringID";
            this.label_selectedstringID.Size = new System.Drawing.Size(55, 13);
            this.label_selectedstringID.TabIndex = 4;
            this.label_selectedstringID.Text = "String ID:";
            // 
            // textbox_stringID
            // 
            this.textbox_stringID.Enabled = false;
            this.textbox_stringID.Location = new System.Drawing.Point(395, 40);
            this.textbox_stringID.Name = "textbox_stringID";
            this.textbox_stringID.Size = new System.Drawing.Size(52, 22);
            this.textbox_stringID.TabIndex = 5;
            // 
            // label_listbox
            // 
            this.label_listbox.AutoSize = true;
            this.label_listbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listbox.Location = new System.Drawing.Point(9, 65);
            this.label_listbox.Name = "label_listbox";
            this.label_listbox.Size = new System.Drawing.Size(194, 13);
            this.label_listbox.TabIndex = 6;
            this.label_listbox.Text = "List of strings in the loaded SCN file:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 362);
            this.Controls.Add(this.label_listbox);
            this.Controls.Add(this.textbox_stringID);
            this.Controls.Add(this.label_selectedstringID);
            this.Controls.Add(this.label_searchinstruction);
            this.Controls.Add(this.label_editinstruction);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textbox_search);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textbox_editing);
            this.Controls.Add(this.listBox_strings);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(475, 400);
            this.MinimumSize = new System.Drawing.Size(475, 400);
            this.Name = "Form1";
            this.Text = "Advanced SCN Editor v0.1a";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_strings;
        private System.Windows.Forms.TextBox textbox_editing;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_OpenSCNFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SaveSCNFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_editinstruction;
        private System.Windows.Forms.Label label_searchinstruction;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label_selectedstringID;
        private System.Windows.Forms.TextBox textbox_stringID;
        private System.Windows.Forms.Label label_listbox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Huffman;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Huffman_DecompressImage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Huffman_CompressImage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_TryRecovery;
        private System.Windows.Forms.ToolStripMenuItem tJS2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_TJS2_Open;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_TJS2_Save;
    }
}

