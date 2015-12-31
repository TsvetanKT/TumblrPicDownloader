namespace TumblrPicDownloader
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
            this.components = new System.ComponentModel.Container();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tumblrUrlTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startPageNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.radioAllPages = new System.Windows.Forms.RadioButton();
            this.radioFirstXPages = new System.Windows.Forms.RadioButton();
            this.radioStartFromPage = new System.Windows.Forms.RadioButton();
            this.firstXPagesNumeric = new System.Windows.Forms.NumericUpDown();
            this.untilPageNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSkipSameFiles = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericCounterFormat = new System.Windows.Forms.NumericUpDown();
            this.labelCounterZeroes = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.subfolderCheck = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLogger = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.startPageNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstXPagesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.untilPageNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCounterFormat)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(15, 57);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(132, 37);
            this.selectFolderButton.TabIndex = 0;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(15, 100);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(526, 20);
            this.folderTextBox.TabIndex = 1;
            this.folderTextBox.Text = "Z:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // tumblrUrlTextbox
            // 
            this.tumblrUrlTextbox.Location = new System.Drawing.Point(84, 19);
            this.tumblrUrlTextbox.Name = "tumblrUrlTextbox";
            this.tumblrUrlTextbox.Size = new System.Drawing.Size(200, 20);
            this.tumblrUrlTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tumblr page";
            // 
            // startPageNumeric
            // 
            this.startPageNumeric.Enabled = false;
            this.startPageNumeric.Location = new System.Drawing.Point(385, 19);
            this.startPageNumeric.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.startPageNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startPageNumeric.Name = "startPageNumeric";
            this.startPageNumeric.Size = new System.Drawing.Size(79, 20);
            this.startPageNumeric.TabIndex = 5;
            this.startPageNumeric.Tag = "";
            this.startPageNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Until page";
            // 
            // radioAllPages
            // 
            this.radioAllPages.AutoSize = true;
            this.radioAllPages.Checked = true;
            this.radioAllPages.Location = new System.Drawing.Point(14, 19);
            this.radioAllPages.Name = "radioAllPages";
            this.radioAllPages.Size = new System.Drawing.Size(68, 17);
            this.radioAllPages.TabIndex = 8;
            this.radioAllPages.TabStop = true;
            this.radioAllPages.Text = "All pages";
            this.radioAllPages.UseVisualStyleBackColor = true;
            // 
            // radioFirstXPages
            // 
            this.radioFirstXPages.AutoSize = true;
            this.radioFirstXPages.Location = new System.Drawing.Point(105, 19);
            this.radioFirstXPages.Name = "radioFirstXPages";
            this.radioFirstXPages.Size = new System.Drawing.Size(44, 17);
            this.radioFirstXPages.TabIndex = 9;
            this.radioFirstXPages.Text = "First";
            this.radioFirstXPages.UseVisualStyleBackColor = true;
            this.radioFirstXPages.CheckedChanged += new System.EventHandler(this.RadioFirstXPages_CheckedChanged);
            // 
            // radioStartFromPage
            // 
            this.radioStartFromPage.AutoSize = true;
            this.radioStartFromPage.Location = new System.Drawing.Point(287, 19);
            this.radioStartFromPage.Name = "radioStartFromPage";
            this.radioStartFromPage.Size = new System.Drawing.Size(97, 17);
            this.radioStartFromPage.TabIndex = 10;
            this.radioStartFromPage.Text = "Start from page";
            this.radioStartFromPage.UseVisualStyleBackColor = true;
            this.radioStartFromPage.CheckedChanged += new System.EventHandler(this.RadioStartFromPage_CheckedChanged);
            // 
            // firstXPagesNumeric
            // 
            this.firstXPagesNumeric.Enabled = false;
            this.firstXPagesNumeric.Location = new System.Drawing.Point(156, 19);
            this.firstXPagesNumeric.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.firstXPagesNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.firstXPagesNumeric.Name = "firstXPagesNumeric";
            this.firstXPagesNumeric.Size = new System.Drawing.Size(61, 20);
            this.firstXPagesNumeric.TabIndex = 11;
            this.firstXPagesNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // untilPageNumeric
            // 
            this.untilPageNumeric.Enabled = false;
            this.untilPageNumeric.Location = new System.Drawing.Point(385, 45);
            this.untilPageNumeric.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.untilPageNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.untilPageNumeric.Name = "untilPageNumeric";
            this.untilPageNumeric.Size = new System.Drawing.Size(79, 20);
            this.untilPageNumeric.TabIndex = 12;
            this.untilPageNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "pages";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(89, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 17);
            this.radioButton4.TabIndex = 22;
            this.radioButton4.Text = "Original";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(14, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(62, 17);
            this.radioButton5.TabIndex = 23;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Counter";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(155, 18);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(136, 17);
            this.radioButton6.TabIndex = 24;
            this.radioButton6.Text = "Counter + page number";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(299, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(94, 17);
            this.radioButton7.TabIndex = 25;
            this.radioButton7.Text = "Text + counter";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.RadioButton7_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(399, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 20);
            this.textBox3.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSkipSameFiles);
            this.groupBox1.Controls.Add(this.radioAllPages);
            this.groupBox1.Controls.Add(this.radioFirstXPages);
            this.groupBox1.Controls.Add(this.radioStartFromPage);
            this.groupBox1.Controls.Add(this.firstXPagesNumeric);
            this.groupBox1.Controls.Add(this.untilPageNumeric);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.startPageNumeric);
            this.groupBox1.Location = new System.Drawing.Point(15, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 73);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download";
            // 
            // checkBoxSkipSameFiles
            // 
            this.checkBoxSkipSameFiles.AutoSize = true;
            this.checkBoxSkipSameFiles.Checked = true;
            this.checkBoxSkipSameFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSkipSameFiles.Location = new System.Drawing.Point(14, 47);
            this.checkBoxSkipSameFiles.Name = "checkBoxSkipSameFiles";
            this.checkBoxSkipSameFiles.Size = new System.Drawing.Size(96, 17);
            this.checkBoxSkipSameFiles.TabIndex = 14;
            this.checkBoxSkipSameFiles.Text = "Skip same files";
            this.checkBoxSkipSameFiles.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton13);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton12);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Controls.Add(this.radioButton11);
            this.groupBox2.Controls.Add(this.radioButton10);
            this.groupBox2.Location = new System.Drawing.Point(15, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 69);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sizes";
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(287, 28);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(37, 17);
            this.radioButton13.TabIndex = 5;
            this.radioButton13.Text = "75";
            this.toolTip1.SetToolTip(this.radioButton13, "Min quality");
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Checked = true;
            this.radioButton8.Location = new System.Drawing.Point(19, 28);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(49, 17);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "1280";
            this.toolTip1.SetToolTip(this.radioButton8, "Max quality");
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(238, 27);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(43, 17);
            this.radioButton12.TabIndex = 4;
            this.radioButton12.Text = "100";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(78, 28);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(43, 17);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.Text = "500";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(189, 28);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(43, 17);
            this.radioButton11.TabIndex = 3;
            this.radioButton11.Text = "250";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(140, 27);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(43, 17);
            this.radioButton10.TabIndex = 2;
            this.radioButton10.Text = "400";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericCounterFormat);
            this.groupBox3.Controls.Add(this.labelCounterZeroes);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Location = new System.Drawing.Point(15, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 86);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File names";
            // 
            // numericCounterFormat
            // 
            this.numericCounterFormat.Location = new System.Drawing.Point(135, 52);
            this.numericCounterFormat.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericCounterFormat.Name = "numericCounterFormat";
            this.numericCounterFormat.Size = new System.Drawing.Size(36, 20);
            this.numericCounterFormat.TabIndex = 28;
            this.numericCounterFormat.Tag = "";
            this.numericCounterFormat.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // labelCounterZeroes
            // 
            this.labelCounterZeroes.AutoSize = true;
            this.labelCounterZeroes.Location = new System.Drawing.Point(14, 54);
            this.labelCounterZeroes.Name = "labelCounterZeroes";
            this.labelCounterZeroes.Size = new System.Drawing.Size(115, 13);
            this.labelCounterZeroes.TabIndex = 27;
            this.labelCounterZeroes.Text = "Counter leading zeroes";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox7);
            this.groupBox4.Controls.Add(this.checkBox8);
            this.groupBox4.Controls.Add(this.checkBox9);
            this.groupBox4.Location = new System.Drawing.Point(364, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 69);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "File types";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(16, 28);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(46, 17);
            this.checkBox7.TabIndex = 15;
            this.checkBox7.Text = "JPG";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(68, 28);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(49, 17);
            this.checkBox8.TabIndex = 16;
            this.checkBox8.Text = "PNG";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Location = new System.Drawing.Point(123, 28);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(43, 17);
            this.checkBox9.TabIndex = 17;
            this.checkBox9.Text = "GIF";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // subfolderCheck
            // 
            this.subfolderCheck.AutoSize = true;
            this.subfolderCheck.Checked = true;
            this.subfolderCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subfolderCheck.Location = new System.Drawing.Point(159, 68);
            this.subfolderCheck.Name = "subfolderCheck";
            this.subfolderCheck.Size = new System.Drawing.Size(186, 17);
            this.subfolderCheck.TabIndex = 31;
            this.subfolderCheck.Text = "Make a subfolder with page name";
            this.subfolderCheck.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(371, 15);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(170, 39);
            this.startButton.TabIndex = 32;
            this.startButton.Text = "Go";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // openFolderButton
            // 
            this.openFolderButton.Location = new System.Drawing.Point(371, 68);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(170, 24);
            this.openFolderButton.TabIndex = 35;
            this.openFolderButton.Text = "Open destination folder";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(15, 373);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(183, 111);
            this.textBoxOutput.TabIndex = 36;
            this.textBoxOutput.Text = "";
            // 
            // richTextBoxLogger
            // 
            this.richTextBoxLogger.Location = new System.Drawing.Point(204, 373);
            this.richTextBoxLogger.Name = "richTextBoxLogger";
            this.richTextBoxLogger.ReadOnly = true;
            this.richTextBoxLogger.Size = new System.Drawing.Size(337, 111);
            this.richTextBoxLogger.TabIndex = 37;
            this.richTextBoxLogger.Text = "";
            this.richTextBoxLogger.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RichTextBoxLogger_LinkClicked);
            this.richTextBoxLogger.TextChanged += new System.EventHandler(this.RichTextBoxLogger_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(481, 487);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 13);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "TsvetanKT";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 502);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.richTextBoxLogger);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.openFolderButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.subfolderCheck);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tumblrUrlTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.selectFolderButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tumblr Pic Downloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startPageNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstXPagesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.untilPageNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCounterFormat)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tumblrUrlTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown startPageNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioAllPages;
        private System.Windows.Forms.RadioButton radioFirstXPages;
        private System.Windows.Forms.RadioButton radioStartFromPage;
        private System.Windows.Forms.NumericUpDown firstXPagesNumeric;
        private System.Windows.Forms.NumericUpDown untilPageNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.CheckBox subfolderCheck;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.NumericUpDown numericCounterFormat;
        private System.Windows.Forms.Label labelCounterZeroes;
        private System.Windows.Forms.RichTextBox textBoxOutput;
        private System.Windows.Forms.RichTextBox richTextBoxLogger;
        private System.Windows.Forms.CheckBox checkBoxSkipSameFiles;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}