﻿using System;
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
        public TestForm()
        {
            InitializeComponent();
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
