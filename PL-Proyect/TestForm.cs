using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class TestForm : Form
    {
        public static placeholderForm placeholderForm = null;
        public static aboutForm aboutFrom = null;
        public static breakForm breakForm = null;
        public static caseForm caseForm = null;
        public static elseForm elseForm = null;
        public static forForm forForm = null;
        public static functionCreateForm functionCreateForm = null;
        public static helpForm helpForm = null;
        public static ifForm ifForm = null;
        public static mathForm mathForm = null;
        public static printTextForm printTextForm = null;
        public static printValueForm printValueForm = null;
        public static returnForm returnForm = null;
        public static switchForm switchForm = null;
        public static variableForm variableForm = null;
        public static whileForm whileForm = null;

        public TestForm()
        {
            InitializeComponent();
            ConsoleWrite("Click the \"help\" tab for instructions on how this program works");
            ConsoleWrite("Click the \"example\" tab to see example programs");
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void entryField_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHelloWorld_click(object sender, EventArgs e)
        {
            //outputScreen.AppendText(">Hello World\n");
            ConsoleWrite("Hello World");
            codeInTextPanel.Text = codeInTextPanel.Text.Insert(133, "ConsoleWrite(\"Hello World\");");
            //this method is hell and should be changed as soon as possible
        }

        private void tbSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            UserWrite(entryField.Text);
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                UserWrite(entryField.Text);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm aboutForm = new aboutForm();
            aboutForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbHelp_Click(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            help.Show();
        }

        private void codeInTextPanel_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void defaultCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeInTextPanel.Text = "using System;\n\nnamespace LearningSpace\n{\n\tstatic class Program\n\t{\n\t\tstatic void Main(string[] args)\n\t\t{\n\t\t\t//Your code goes here!\n\t\t\t\n\t\t}\n\t}\n}";
        }

        //Custom functions start

        private void ConsoleWrite(string s)
        {
            outputScreen.SelectionColor = Color.Green;
            s = ">" + s;
            outputScreen.AppendText(s+"\n");
        }

        private void UserWrite(string s)
        {
            outputScreen.SelectionColor = Color.Red;
            s = "-" + s;
            outputScreen.AppendText(s + "\n");
            entryField.Text = "";
        }

        //Custom functions end

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsoleWrite("To undo please press Ctrl+Z, this also works on most apps!");
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsoleWrite("To redo please press Ctrl+Y, this also works on most apps!");
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void printTextBt_Click(object sender, EventArgs e)
        {
            if (printTextForm==null)
            {
                printTextForm = new printTextForm();
                printTextForm.Show();
            }
            else
            {
                printTextForm.BringToFront();
            }
        }

        private void printValuebtn_Click(object sender, EventArgs e)
        {
            if (printValueForm==null)
            {
                printValueForm = new printValueForm();
                printValueForm.Show();
            }
            else
            {
                printValueForm.BringToFront();
            }
        }

        private void variableSetbt_Click(object sender, EventArgs e)
        {
            if (variableForm==null)
            {
                variableForm = new variableForm();
                variableForm.Show();
            }
            else
            {
                variableForm.BringToFront();
            }
        }

        private void mathbt_Click(object sender, EventArgs e)
        {
            if (mathForm==null)
            {
                mathForm = new mathForm();
                mathForm.Show();
            }
            else
            {
                mathForm.BringToFront();
            }
        }

        private void ifbt_Click(object sender, EventArgs e)
        {
            if (ifForm==null)
            {
                ifForm = new ifForm();
                ifForm.Show();
            }
            else
            {
                ifForm.BringToFront();
            }
        }

        private void elsebt_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("else{\n\t\t\t\t\t\n\t\t\t}");
            if (elseForm==null)
            {
                elseForm = new elseForm();
                elseForm.Show();
            }
            else
            {
                elseForm.BringToFront();
            }
        }

        private void whilebt_Click(object sender, EventArgs e)
        {
            if (whileForm==null)
            {
                whileForm = new whileForm();
                whileForm.Show();
            }
            else
            {
                whileForm.BringToFront();
            }
        }

        private void forbt_Click(object sender, EventArgs e)
        {
            if (forForm==null)
            {
                forForm = new forForm();
                forForm.Show();
            }
            else
            {
                forForm.BringToFront();
            }
        }

        private void switchbt_Click(object sender, EventArgs e)
        {
            if (switchForm==null)
            {
                switchForm = new switchForm();
                switchForm.Show();
            }
            else
            {
                switchForm.BringToFront();
            }
        }

        private void casebt_Click(object sender, EventArgs e)
        {
            if (caseForm==null)
            {
                caseForm = new caseForm();
                caseForm.Show();
            }
            else
            {
                caseForm.BringToFront();
            }
        }

        private void breakbt_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("break;");
            if (breakForm==null)
            {
                breakForm = new breakForm();
                breakForm.Show();
            }
            else
            {
                breakForm.BringToFront();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (functionCreateForm==null)
            {
                functionCreateForm = new functionCreateForm();
                functionCreateForm.Show();
            }
            else
            {
                functionCreateForm.BringToFront();
            }
        }

        private void returnbt_Click(object sender, EventArgs e)
        {
            if (returnForm == null)
            {
                returnForm = new returnForm();
                returnForm.Show();
            }
            else
            {
                returnForm.BringToFront();
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (placeholderForm == null)
            {
                placeholderForm = new placeholderForm();
                placeholderForm.Show();
            }
            else
            {
                placeholderForm.BringToFront();
            }
        }

        private void tbRun_Click(object sender, EventArgs e)
        {
            ConsoleWrite("I'm sorry, I can't do that yet");
        }
    }
}
