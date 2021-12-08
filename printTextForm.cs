using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BabyCsharpProject
{
    public partial class printTextForm : Form
    {
        //Final Commit for Grading
        bool v = false;
        public printTextForm()
        {
            InitializeComponent();
        }

        private void printTextForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.printTextForm = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((int.TryParse(textBox1.Text, out _))) || ((bool.TryParse(textBox1.Text, out _))) || ((double.TryParse(textBox1.Text, out _))) || TestForm.userVariables.Contains(textBox1.Text) || v)
            {
                Clipboard.SetText("Console.WriteLine(" + textBox1.Text + ");");
                this.Close();
            }
            else
            {
                Clipboard.SetText("Console.WriteLine(\"" + textBox1.Text + "\");");
                this.Close();
            }
        }
        
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (((int.TryParse(textBox1.Text, out _))) || ((bool.TryParse(textBox1.Text, out _))) || ((double.TryParse(textBox1.Text, out _))) || TestForm.userVariables.Contains(textBox1.Text))
                {
                    Clipboard.SetText("Console.WriteLine(" + textBox1.Text + ");");
                    this.Close();
                }
                else
                {
                    Clipboard.SetText("Console.WriteLine(\"" + textBox1.Text + "\");");
                    this.Close();
                }
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            v = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            v = false;
        }
    }
}
