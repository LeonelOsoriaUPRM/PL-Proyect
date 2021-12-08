using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BabyCsharpProject
{
    public partial class whileForm : Form
    {
        //Final Commit for Grading
        public whileForm()
        {
            InitializeComponent();
        }

        private void whileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.whileForm = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("while ("+textBox1.Text+ ")\n\t\t\t{\n\t\t\t\t//place \"cases\" here\n\t\t\t\t\n\t\t\t}");
            this.Close();
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Clipboard.SetText("while (" + textBox1.Text + ")\n\t\t\t{\n\t\t\t\t//place \"cases\" here\n\t\t\t\t\n\t\t\t}");
                this.Close();
            }
        }
    }
}
