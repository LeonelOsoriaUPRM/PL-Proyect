
namespace PL_Proyect
{
    partial class TestForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.tbFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tbNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tbOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tbEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tbRun = new System.Windows.Forms.ToolStripMenuItem();
            this.tbExample = new System.Windows.Forms.ToolStripMenuItem();
            this.tbHelloWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.tbHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputScreen = new System.Windows.Forms.RichTextBox();
            this.entryField = new System.Windows.Forms.TextBox();
            this.codeGoesHere = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbFile,
            this.tbEdit,
            this.tbRun,
            this.tbExample,
            this.tbHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(944, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // tbFile
            // 
            this.tbFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNew,
            this.tbOpen,
            this.toolStripSeparator1,
            this.tbSaveAs});
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(37, 20);
            this.tbFile.Text = "File";
            // 
            // tbNew
            // 
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(111, 22);
            this.tbNew.Text = "New";
            // 
            // tbOpen
            // 
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(111, 22);
            this.tbOpen.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
            // 
            // tbSaveAs
            // 
            this.tbSaveAs.Name = "tbSaveAs";
            this.tbSaveAs.Size = new System.Drawing.Size(111, 22);
            this.tbSaveAs.Text = "SaveAs";
            this.tbSaveAs.Click += new System.EventHandler(this.tbSaveAs_Click);
            // 
            // tbEdit
            // 
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(39, 20);
            this.tbEdit.Text = "Edit";
            // 
            // tbRun
            // 
            this.tbRun.Name = "tbRun";
            this.tbRun.Size = new System.Drawing.Size(40, 20);
            this.tbRun.Text = "Run";
            // 
            // tbExample
            // 
            this.tbExample.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbHelloWorld});
            this.tbExample.Name = "tbExample";
            this.tbExample.Size = new System.Drawing.Size(69, 20);
            this.tbExample.Text = "Examples";
            // 
            // tbHelloWorld
            // 
            this.tbHelloWorld.Name = "tbHelloWorld";
            this.tbHelloWorld.Size = new System.Drawing.Size(140, 22);
            this.tbHelloWorld.Text = "Hello Wolrd!";
            this.tbHelloWorld.Click += new System.EventHandler(this.tbHelloWorld_click);
            // 
            // tbHelp
            // 
            this.tbHelp.Name = "tbHelp";
            this.tbHelp.Size = new System.Drawing.Size(44, 20);
            this.tbHelp.Text = "Help";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-349, -139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // outputScreen
            // 
            this.outputScreen.BackColor = System.Drawing.SystemColors.WindowText;
            this.outputScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputScreen.EnableAutoDragDrop = true;
            this.outputScreen.ForeColor = System.Drawing.SystemColors.Window;
            this.outputScreen.Location = new System.Drawing.Point(0, 420);
            this.outputScreen.Name = "outputScreen";
            this.outputScreen.ReadOnly = true;
            this.outputScreen.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.outputScreen.Size = new System.Drawing.Size(292, 263);
            this.outputScreen.TabIndex = 4;
            this.outputScreen.TabStop = false;
            this.outputScreen.Text = "I wrote this text here\nThe code wrote the text down here:\n ";
            // 
            // entryField
            // 
            this.entryField.Location = new System.Drawing.Point(0, 391);
            this.entryField.Name = "entryField";
            this.entryField.Size = new System.Drawing.Size(239, 23);
            this.entryField.TabIndex = 5;
            this.entryField.TextChanged += new System.EventHandler(this.entryField_TextChanged);
            this.entryField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            // 
            // codeGoesHere
            // 
            this.codeGoesHere.BackColor = System.Drawing.SystemColors.WindowText;
            this.codeGoesHere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeGoesHere.ForeColor = System.Drawing.SystemColors.Window;
            this.codeGoesHere.Location = new System.Drawing.Point(599, 24);
            this.codeGoesHere.Name = "codeGoesHere";
            this.codeGoesHere.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.codeGoesHere.Size = new System.Drawing.Size(345, 659);
            this.codeGoesHere.TabIndex = 6;
            this.codeGoesHere.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(245, 391);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(47, 23);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.codeGoesHere);
            this.Controls.Add(this.entryField);
            this.Controls.Add(this.outputScreen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "TestForm";
            this.Text = "Name of Program here";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem tbFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem tbNew;
        private System.Windows.Forms.ToolStripMenuItem tbOpen;
        private System.Windows.Forms.ToolStripMenuItem tbSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tbEdit;
        private System.Windows.Forms.ToolStripMenuItem tbRun;
        private System.Windows.Forms.ToolStripMenuItem tbExample;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox outputScreen;
        private System.Windows.Forms.TextBox entryField;
        private System.Windows.Forms.RichTextBox codeGoesHere;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ToolStripMenuItem tbHelloWorld;
        private System.Windows.Forms.ToolStripMenuItem tbHelp;
    }
}

