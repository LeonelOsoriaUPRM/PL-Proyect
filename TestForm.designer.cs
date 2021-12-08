
namespace BabyCsharpProject
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
            this.clearOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbRun = new System.Windows.Forms.ToolStripMenuItem();
            this.tbExample = new System.Windows.Forms.ToolStripMenuItem();
            this.tbHelloWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.abcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputScreen = new System.Windows.Forms.RichTextBox();
            this.entryField = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.codeInTextPanel = new System.Windows.Forms.RichTextBox();
            this.returnbt = new System.Windows.Forms.Button();
            this.functionbt = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.breakbt = new System.Windows.Forms.Button();
            this.casebt = new System.Windows.Forms.Button();
            this.switchbt = new System.Windows.Forms.Button();
            this.forbt = new System.Windows.Forms.Button();
            this.whilebt = new System.Windows.Forms.Button();
            this.elsebt = new System.Windows.Forms.Button();
            this.ifbt = new System.Windows.Forms.Button();
            this.mathbt = new System.Windows.Forms.Button();
            this.variableSetbt = new System.Windows.Forms.Button();
            this.printValuebtn = new System.Windows.Forms.Button();
            this.printTextBt = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.forExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbFile,
            this.tbEdit,
            this.buildToolStripMenuItem,
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
            this.tbNew.Click += new System.EventHandler(this.tbNew_Click);
            // 
            // tbOpen
            // 
            this.tbOpen.Name = "tbOpen";
            resources.ApplyResources(this.tbOpen, "tbOpen");
            this.tbOpen.Click += new System.EventHandler(this.tbOpen_Click);
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
            this.defaultCode,
            this.clearOutputToolStripMenuItem,
            this.toolStripSeparator2});
            this.tbEdit.Name = "tbEdit";
            resources.ApplyResources(this.tbEdit, "tbEdit");
            // 
            // defaultCode
            // 
            this.defaultCode.Name = "defaultCode";
            resources.ApplyResources(this.defaultCode, "defaultCode");
            this.defaultCode.Click += new System.EventHandler(this.defaultCodeToolStripMenuItem_Click);
            // 
            // clearOutputToolStripMenuItem
            // 
            this.clearOutputToolStripMenuItem.Name = "clearOutputToolStripMenuItem";
            resources.ApplyResources(this.clearOutputToolStripMenuItem, "clearOutputToolStripMenuItem");
            this.clearOutputToolStripMenuItem.Click += new System.EventHandler(this.clearOutputToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            resources.ApplyResources(this.buildToolStripMenuItem, "buildToolStripMenuItem");
            this.buildToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
            // 
            // tbRun
            // 
            this.tbRun.Name = "tbRun";
            resources.ApplyResources(this.tbRun, "tbRun");
            this.tbRun.Click += new System.EventHandler(this.tbRun_Click);
            // 
            // tbExample
            // 
            this.tbExample.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbHelloWorld,
            this.abcToolStripMenuItem,
            this.forExampleToolStripMenuItem});
            this.tbExample.Name = "tbExample";
            resources.ApplyResources(this.tbExample, "tbExample");
            // 
            // tbHelloWorld
            // 
            this.tbHelloWorld.Name = "tbHelloWorld";
            resources.ApplyResources(this.tbHelloWorld, "tbHelloWorld");
            this.tbHelloWorld.Click += new System.EventHandler(this.tbHelloWorld_click);
            // 
            // abcToolStripMenuItem
            // 
            this.abcToolStripMenuItem.Name = "abcToolStripMenuItem";
            resources.ApplyResources(this.abcToolStripMenuItem, "abcToolStripMenuItem");
            this.abcToolStripMenuItem.Click += new System.EventHandler(this.abcToolStripMenuItem_Click);
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
            // 
            // outputScreen
            // 
            resources.ApplyResources(this.outputScreen, "outputScreen");
            this.outputScreen.BackColor = System.Drawing.SystemColors.WindowText;
            this.outputScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputScreen.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.codeInTextPanel.AcceptsTab = true;
            resources.ApplyResources(this.codeInTextPanel, "codeInTextPanel");
            this.codeInTextPanel.AutoWordSelection = true;
            this.codeInTextPanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.codeInTextPanel.EnableAutoDragDrop = true;
            this.codeInTextPanel.ForeColor = System.Drawing.SystemColors.Window;
            this.codeInTextPanel.Name = "codeInTextPanel";
            this.codeInTextPanel.ShowSelectionMargin = true;
            // 
            // returnbt
            // 
            resources.ApplyResources(this.returnbt, "returnbt");
            this.returnbt.Name = "returnbt";
            this.returnbt.UseVisualStyleBackColor = true;
            this.returnbt.Click += new System.EventHandler(this.returnbt_Click);
            // 
            // functionbt
            // 
            resources.ApplyResources(this.functionbt, "functionbt");
            this.functionbt.Name = "functionbt";
            this.functionbt.UseVisualStyleBackColor = true;
            this.functionbt.Click += new System.EventHandler(this.button13_Click);
            // 
            // btn12
            // 
            resources.ApplyResources(this.btn12, "btn12");
            this.btn12.Name = "btn12";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // breakbt
            // 
            resources.ApplyResources(this.breakbt, "breakbt");
            this.breakbt.Name = "breakbt";
            this.breakbt.UseVisualStyleBackColor = true;
            this.breakbt.Click += new System.EventHandler(this.breakbt_Click);
            // 
            // casebt
            // 
            resources.ApplyResources(this.casebt, "casebt");
            this.casebt.Name = "casebt";
            this.casebt.UseVisualStyleBackColor = true;
            this.casebt.Click += new System.EventHandler(this.casebt_Click);
            // 
            // switchbt
            // 
            resources.ApplyResources(this.switchbt, "switchbt");
            this.switchbt.Name = "switchbt";
            this.switchbt.UseVisualStyleBackColor = true;
            this.switchbt.Click += new System.EventHandler(this.switchbt_Click);
            // 
            // forbt
            // 
            resources.ApplyResources(this.forbt, "forbt");
            this.forbt.Name = "forbt";
            this.forbt.UseVisualStyleBackColor = true;
            this.forbt.Click += new System.EventHandler(this.forbt_Click);
            // 
            // whilebt
            // 
            resources.ApplyResources(this.whilebt, "whilebt");
            this.whilebt.Name = "whilebt";
            this.whilebt.UseVisualStyleBackColor = true;
            this.whilebt.Click += new System.EventHandler(this.whilebt_Click);
            // 
            // elsebt
            // 
            resources.ApplyResources(this.elsebt, "elsebt");
            this.elsebt.Name = "elsebt";
            this.elsebt.UseVisualStyleBackColor = true;
            this.elsebt.Click += new System.EventHandler(this.elsebt_Click);
            // 
            // ifbt
            // 
            resources.ApplyResources(this.ifbt, "ifbt");
            this.ifbt.Name = "ifbt";
            this.ifbt.UseVisualStyleBackColor = true;
            this.ifbt.Click += new System.EventHandler(this.ifbt_Click);
            // 
            // mathbt
            // 
            resources.ApplyResources(this.mathbt, "mathbt");
            this.mathbt.Name = "mathbt";
            this.mathbt.UseVisualStyleBackColor = true;
            this.mathbt.Click += new System.EventHandler(this.mathbt_Click);
            // 
            // variableSetbt
            // 
            resources.ApplyResources(this.variableSetbt, "variableSetbt");
            this.variableSetbt.Name = "variableSetbt";
            this.variableSetbt.UseVisualStyleBackColor = true;
            this.variableSetbt.Click += new System.EventHandler(this.variableSetbt_Click);
            // 
            // printValuebtn
            // 
            resources.ApplyResources(this.printValuebtn, "printValuebtn");
            this.printValuebtn.Name = "printValuebtn";
            this.printValuebtn.UseVisualStyleBackColor = true;
            this.printValuebtn.Click += new System.EventHandler(this.printValuebtn_Click);
            // 
            // printTextBt
            // 
            resources.ApplyResources(this.printTextBt, "printTextBt");
            this.printTextBt.Name = "printTextBt";
            this.printTextBt.UseVisualStyleBackColor = true;
            this.printTextBt.Click += new System.EventHandler(this.printTextBt_Click);
            // 
            // buttonPanel
            // 
            resources.ApplyResources(this.buttonPanel, "buttonPanel");
            this.buttonPanel.Controls.Add(this.printTextBt);
            this.buttonPanel.Controls.Add(this.printValuebtn);
            this.buttonPanel.Controls.Add(this.variableSetbt);
            this.buttonPanel.Controls.Add(this.mathbt);
            this.buttonPanel.Controls.Add(this.ifbt);
            this.buttonPanel.Controls.Add(this.elsebt);
            this.buttonPanel.Controls.Add(this.whilebt);
            this.buttonPanel.Controls.Add(this.forbt);
            this.buttonPanel.Controls.Add(this.switchbt);
            this.buttonPanel.Controls.Add(this.casebt);
            this.buttonPanel.Controls.Add(this.btn12);
            this.buttonPanel.Controls.Add(this.breakbt);
            this.buttonPanel.Controls.Add(this.functionbt);
            this.buttonPanel.Controls.Add(this.returnbt);
            this.buttonPanel.Name = "buttonPanel";
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
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // forExampleToolStripMenuItem
            // 
            this.forExampleToolStripMenuItem.Name = "forExampleToolStripMenuItem";
            resources.ApplyResources(this.forExampleToolStripMenuItem, "forExampleToolStripMenuItem");
            this.forExampleToolStripMenuItem.Click += new System.EventHandler(this.forExampleToolStripMenuItem_Click);
            // 
            // TestForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.codeInTextPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputScreen);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.entryField);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "TestForm";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button returnbt;
        private System.Windows.Forms.Button functionbt;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button breakbt;
        private System.Windows.Forms.Button casebt;
        private System.Windows.Forms.Button switchbt;
        private System.Windows.Forms.Button forbt;
        private System.Windows.Forms.Button whilebt;
        private System.Windows.Forms.Button elsebt;
        private System.Windows.Forms.Button ifbt;
        private System.Windows.Forms.Button mathbt;
        private System.Windows.Forms.Button variableSetbt;
        private System.Windows.Forms.Button printValuebtn;
        private System.Windows.Forms.Button printTextBt;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.ToolStripMenuItem clearOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forExampleToolStripMenuItem;
    }
}

