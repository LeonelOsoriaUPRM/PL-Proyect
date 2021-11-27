
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
            this.defaultCode = new System.Windows.Forms.ToolStripMenuItem();
            this.tbRun = new System.Windows.Forms.ToolStripMenuItem();
            this.tbExample = new System.Windows.Forms.ToolStripMenuItem();
            this.tbHelloWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.tbHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputScreen = new System.Windows.Forms.RichTextBox();
            this.entryField = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.codeInTextPanel = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbFile,
            this.tbEdit,
            this.tbRun,
            this.tbExample,
            this.tbHelp,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Name = "mainMenu";
            // 
            // tbFile
            // 
            this.tbFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNew,
            this.tbOpen,
            this.toolStripSeparator1,
            this.tbSaveAs});
            this.tbFile.Name = "tbFile";
            resources.ApplyResources(this.tbFile, "tbFile");
            // 
            // tbNew
            // 
            this.tbNew.Name = "tbNew";
            resources.ApplyResources(this.tbNew, "tbNew");
            // 
            // tbOpen
            // 
            this.tbOpen.Name = "tbOpen";
            resources.ApplyResources(this.tbOpen, "tbOpen");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tbSaveAs
            // 
            this.tbSaveAs.Name = "tbSaveAs";
            resources.ApplyResources(this.tbSaveAs, "tbSaveAs");
            this.tbSaveAs.Click += new System.EventHandler(this.tbSaveAs_Click);
            // 
            // tbEdit
            // 
            this.tbEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultCode});
            this.tbEdit.Name = "tbEdit";
            resources.ApplyResources(this.tbEdit, "tbEdit");
            // 
            // defaultCode
            // 
            this.defaultCode.Name = "defaultCode";
            resources.ApplyResources(this.defaultCode, "defaultCode");
            this.defaultCode.Click += new System.EventHandler(this.defaultCodeToolStripMenuItem_Click);
            // 
            // tbRun
            // 
            this.tbRun.Name = "tbRun";
            resources.ApplyResources(this.tbRun, "tbRun");
            // 
            // tbExample
            // 
            this.tbExample.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbHelloWorld});
            this.tbExample.Name = "tbExample";
            resources.ApplyResources(this.tbExample, "tbExample");
            // 
            // tbHelloWorld
            // 
            this.tbHelloWorld.Name = "tbHelloWorld";
            resources.ApplyResources(this.tbHelloWorld, "tbHelloWorld");
            this.tbHelloWorld.Click += new System.EventHandler(this.tbHelloWorld_click);
            // 
            // tbHelp
            // 
            this.tbHelp.Name = "tbHelp";
            resources.ApplyResources(this.tbHelp, "tbHelp");
            this.tbHelp.Click += new System.EventHandler(this.tbHelp_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // outputScreen
            // 
            resources.ApplyResources(this.outputScreen, "outputScreen");
            this.outputScreen.BackColor = System.Drawing.SystemColors.WindowText;
            this.outputScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputScreen.EnableAutoDragDrop = true;
            this.outputScreen.ForeColor = System.Drawing.SystemColors.Window;
            this.outputScreen.Name = "outputScreen";
            this.outputScreen.ReadOnly = true;
            this.outputScreen.TabStop = false;
            // 
            // entryField
            // 
            resources.ApplyResources(this.entryField, "entryField");
            this.entryField.ForeColor = System.Drawing.Color.Red;
            this.entryField.Name = "entryField";
            this.entryField.TextChanged += new System.EventHandler(this.entryField_TextChanged);
            this.entryField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // sendButton
            // 
            resources.ApplyResources(this.sendButton, "sendButton");
            this.sendButton.Name = "sendButton";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // codeInTextPanel
            // 
            resources.ApplyResources(this.codeInTextPanel, "codeInTextPanel");
            this.codeInTextPanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.codeInTextPanel.ForeColor = System.Drawing.SystemColors.Window;
            this.codeInTextPanel.Name = "codeInTextPanel";
            this.codeInTextPanel.TextChanged += new System.EventHandler(this.codeInTextPanel_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Controls.Add(this.button11);
            this.flowLayoutPanel1.Controls.Add(this.button12);
            this.flowLayoutPanel1.Controls.Add(this.button13);
            this.flowLayoutPanel1.Controls.Add(this.button14);
            this.flowLayoutPanel1.Controls.Add(this.button15);
            this.flowLayoutPanel1.Controls.Add(this.button16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            resources.ApplyResources(this.button10, "button10");
            this.button10.Name = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            resources.ApplyResources(this.button11, "button11");
            this.button11.Name = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            resources.ApplyResources(this.button12, "button12");
            this.button12.Name = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            resources.ApplyResources(this.button13, "button13");
            this.button13.Name = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            resources.ApplyResources(this.button14, "button14");
            this.button14.Name = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            resources.ApplyResources(this.button15, "button15");
            this.button15.Name = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            resources.ApplyResources(this.button16, "button16");
            this.button16.Name = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.codeInTextPanel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.entryField);
            this.Controls.Add(this.outputScreen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ToolStripMenuItem tbHelloWorld;
        private System.Windows.Forms.ToolStripMenuItem tbHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox codeInTextPanel;
        private System.Windows.Forms.ToolStripMenuItem defaultCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

