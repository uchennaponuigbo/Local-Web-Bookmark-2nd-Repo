namespace Practice_2__Local_Web_Bookmark
{
    partial class BookmarkForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookmarkForm));
            this.WebListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Addbutton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.txtWebLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxLines = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDefaultBrowser = new System.Windows.Forms.Label();
            this.chkIncognito = new System.Windows.Forms.CheckBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblDateSaved = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrLine = new System.Windows.Forms.Label();
            this.txtModifyLink = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebListBox
            // 
            this.WebListBox.ContextMenuStrip = this.contextMenuStrip1;
            this.WebListBox.FormattingEnabled = true;
            this.WebListBox.HorizontalScrollbar = true;
            this.WebListBox.Location = new System.Drawing.Point(11, 176);
            this.WebListBox.Name = "WebListBox";
            this.WebListBox.Size = new System.Drawing.Size(513, 160);
            this.WebListBox.TabIndex = 0;
            this.WebListBox.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            this.WebListBox.SelectedIndexChanged += new System.EventHandler(this.WebListBox_SelectedIndexChanged);
            this.WebListBox.DoubleClick += new System.EventHandler(this.WebListBox_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.visitURLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 70);
            this.contextMenuStrip1.Text = "Copy";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // visitURLToolStripMenuItem
            // 
            this.visitURLToolStripMenuItem.Name = "visitURLToolStripMenuItem";
            this.visitURLToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.visitURLToolStripMenuItem.Text = "Visit URL";
            this.visitURLToolStripMenuItem.Click += new System.EventHandler(this.visitURLToolStripMenuItem_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(12, 43);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 1;
            this.Addbutton.Text = "Add Item";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DeleteButton.Location = new System.Drawing.Point(12, 98);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete Item";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 127);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // txtWebLink
            // 
            this.txtWebLink.Location = new System.Drawing.Point(96, 45);
            this.txtWebLink.Name = "txtWebLink";
            this.txtWebLink.Size = new System.Drawing.Size(428, 20);
            this.txtWebLink.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter a website link or other text.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.optionsToolStripMenuItem.Text = "More";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.informationToolStripMenuItem.Text = "Info...";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            this.saveFileDialog1.Title = "\"Save as Text File\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "File Path:";
            // 
            // lblFilePath
            // 
            this.lblFilePath.Location = new System.Drawing.Point(63, 16);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(331, 34);
            this.lblFilePath.TabIndex = 9;
            this.lblFilePath.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Line:";
            // 
            // lblMaxLines
            // 
            this.lblMaxLines.AutoSize = true;
            this.lblMaxLines.Location = new System.Drawing.Point(74, 157);
            this.lblMaxLines.Name = "lblMaxLines";
            this.lblMaxLines.Size = new System.Drawing.Size(13, 13);
            this.lblMaxLines.TabIndex = 12;
            this.lblMaxLines.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDefaultBrowser);
            this.groupBox1.Controls.Add(this.chkIncognito);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Controls.Add(this.lblDateSaved);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblFilePath);
            this.groupBox1.Location = new System.Drawing.Point(96, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 72);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Name:";
            // 
            // lblDefaultBrowser
            // 
            this.lblDefaultBrowser.AutoSize = true;
            this.lblDefaultBrowser.Location = new System.Drawing.Point(338, 0);
            this.lblDefaultBrowser.Name = "lblDefaultBrowser";
            this.lblDefaultBrowser.Size = new System.Drawing.Size(84, 13);
            this.lblDefaultBrowser.TabIndex = 20;
            this.lblDefaultBrowser.Text = "Internet Explorer\r\n";
            // 
            // chkIncognito
            // 
            this.chkIncognito.AutoSize = true;
            this.chkIncognito.Location = new System.Drawing.Point(294, 50);
            this.chkIncognito.Name = "chkIncognito";
            this.chkIncognito.Size = new System.Drawing.Size(128, 17);
            this.chkIncognito.TabIndex = 19;
            this.chkIncognito.Text = "Visit URL in Incogntio";
            this.chkIncognito.UseVisualStyleBackColor = true;
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(63, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(269, 16);
            this.lblFileName.TabIndex = 18;
            this.lblFileName.Text = "N/A";
            // 
            // lblDateSaved
            // 
            this.lblDateSaved.AutoSize = true;
            this.lblDateSaved.Location = new System.Drawing.Point(93, 50);
            this.lblDateSaved.Name = "lblDateSaved";
            this.lblDateSaved.Size = new System.Drawing.Size(27, 13);
            this.lblDateSaved.TabIndex = 15;
            this.lblDateSaved.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last Saved On:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "/";
            // 
            // lblCurrLine
            // 
            this.lblCurrLine.AutoSize = true;
            this.lblCurrLine.Location = new System.Drawing.Point(39, 157);
            this.lblCurrLine.Name = "lblCurrLine";
            this.lblCurrLine.Size = new System.Drawing.Size(13, 13);
            this.lblCurrLine.TabIndex = 16;
            this.lblCurrLine.Text = "0";
            this.lblCurrLine.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtModifyLink
            // 
            this.txtModifyLink.Location = new System.Drawing.Point(96, 71);
            this.txtModifyLink.Name = "txtModifyLink";
            this.txtModifyLink.Size = new System.Drawing.Size(428, 20);
            this.txtModifyLink.TabIndex = 19;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(12, 71);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 20;
            this.btnModify.Text = "Modify Item";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // BookmarkForm
            // 
            this.AcceptButton = this.Addbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DeleteButton;
            this.ClientSize = new System.Drawing.Size(534, 341);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtModifyLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrLine);
            this.Controls.Add(this.lblMaxLines);
            this.Controls.Add(this.txtWebLink);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WebListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookmarkForm";
            this.Text = "Bookmarks";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WebListBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox txtWebLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitURLToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaxLines;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateSaved;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrLine;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtModifyLink;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.CheckBox chkIncognito;
        private System.Windows.Forms.Label lblDefaultBrowser;
    }
}

