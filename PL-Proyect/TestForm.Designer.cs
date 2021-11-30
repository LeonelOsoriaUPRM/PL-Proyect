
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
            this.printTextBt = new System.Windows.Forms.Button();
            this.printValuebtn = new System.Windows.Forms.Button();
            this.variableSetbt = new System.Windows.Forms.Button();
            this.mathbt = new System.Windows.Forms.Button();
            this.ifbt = new System.Windows.Forms.Button();
            this.elsebt = new System.Windows.Forms.Button();
            this.whilebt = new System.Windows.Forms.Button();
            this.forbt = new System.Windows.Forms.Button();
            this.switchbt = new System.Windows.Forms.Button();
            this.casebt = new System.Windows.Forms.Button();
            this.breakbt = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.returnbt = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel1.Controls.Add(this.printTextBt);
            this.flowLayoutPanel1.Controls.Add(this.printValuebtn);
            this.flowLayoutPanel1.Controls.Add(this.variableSetbt);
            this.flowLayoutPanel1.Controls.Add(this.mathbt);
            this.flowLayoutPanel1.Controls.Add(this.ifbt);
            this.flowLayoutPanel1.Controls.Add(this.elsebt);
            this.flowLayoutPanel1.Controls.Add(this.whilebt);
            this.flowLayoutPanel1.Controls.Add(this.forbt);
            this.flowLayoutPanel1.Controls.Add(this.switchbt);
            this.flowLayoutPanel1.Controls.Add(this.casebt);
            this.flowLayoutPanel1.Controls.Add(this.breakbt);
            this.flowLayoutPanel1.Controls.Add(this.btn12);
            this.flowLayoutPanel1.Controls.Add(this.button13);
            this.flowLayoutPanel1.Controls.Add(this.returnbt);
            this.flowLayoutPanel1.Controls.Add(this.button15);
            this.flowLayoutPanel1.Controls.Add(this.button16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // printTextBt
            // 
            resources.ApplyResources(this.printTextBt, "printTextBt");
            this.printTextBt.Name = "printTextBt";
            this.printTextBt.UseVisualStyleBackColor = true;
            // 
            // printValuebtn
            // 
            resources.ApplyResources(this.printValuebtn, "printValuebtn");
            this.printValuebtn.Name = "printValuebtn";
            this.printValuebtn.UseVisualStyleBackColor = true;
            // 
            // variableSetbt
            // 
            resources.ApplyResources(this.variableSetbt, "variableSetbt");
            this.variableSetbt.Name = "variableSetbt";
            this.variableSetbt.UseVisualStyleBackColor = true;
            // 
            // mathbt
            // 
            resources.ApplyResources(this.mathbt, "mathbt");
            this.mathbt.Name = "mathbt";
            this.mathbt.UseVisualStyleBackColor = true;
            // 
            // ifbt
            // 
            resources.ApplyResources(this.ifbt, "ifbt");
            this.ifbt.Name = "ifbt";
            this.ifbt.UseVisualStyleBackColor = true;
            // 
            // elsebt
            // 
            resources.ApplyResources(this.elsebt, "elsebt");
            this.elsebt.Name = "elsebt";
            this.elsebt.UseVisualStyleBackColor = true;
            // 
            // whilebt
            // 
            resources.ApplyResources(this.whilebt, "whilebt");
            this.whilebt.Name = "whilebt";
            this.whilebt.UseVisualStyleBackColor = true;
            // 
            // forbt
            // 
            resources.ApplyResources(this.forbt, "forbt");
            this.forbt.Name = "forbt";
            this.forbt.UseVisualStyleBackColor = true;
            // 
            // switchbt
            // 
            resources.ApplyResources(this.switchbt, "switchbt");
            this.switchbt.Name = "switchbt";
            this.switchbt.UseVisualStyleBackColor = true;
            // 
            // casebt
            // 
            resources.ApplyResources(this.casebt, "casebt");
            this.casebt.Name = "casebt";
            this.casebt.UseVisualStyleBackColor = true;
            // 
            // breakbt
            // 
            resources.ApplyResources(this.breakbt, "breakbt");
            this.breakbt.Name = "breakbt";
            this.breakbt.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            resources.ApplyResources(this.btn12, "btn12");
            this.btn12.Name = "btn12";
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            resources.ApplyResources(this.button13, "button13");
            this.button13.Name = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // returnbt
            // 
            resources.ApplyResources(this.returnbt, "returnbt");
            this.returnbt.Name = "returnbt";
            this.returnbt.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button printTextBt;
        private System.Windows.Forms.Button printValuebtn;
        private System.Windows.Forms.Button variableSetbt;
        private System.Windows.Forms.Button mathbt;
        private System.Windows.Forms.Button ifbt;
        private System.Windows.Forms.Button elsebt;
        private System.Windows.Forms.Button whilebt;
        private System.Windows.Forms.Button forbt;
        private System.Windows.Forms.Button switchbt;
        private System.Windows.Forms.Button casebt;
        private System.Windows.Forms.Button breakbt;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button returnbt;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

