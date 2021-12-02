using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class ifForm : Form
    {
        public ifForm()
        {
            InitializeComponent();
        }

        private void ifForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.ifForm = null;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Clipboard.SetText("if("+s+ ")\n\t\t\t{\n\t\t\t\t//place code for when condition is true here\n\t\t\t\t\n\t\t\t}");
            this.Close();
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string s = textBox1.Text;
                Clipboard.SetText("if(" + s + ")\n\t\t\t{\n\t\t\t\t//place code for when condition is true here\n\t\t\t\t\n\t\t\t}");
                this.Close();
            }
        }
    }
}
