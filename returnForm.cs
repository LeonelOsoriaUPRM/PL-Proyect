using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BabyCsharpProject
{
    public partial class returnForm : Form
    {
        //Final Commit for Grading
        public returnForm()
        {
            InitializeComponent();
        }

        private void returnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.returnForm = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("return " + textBox1.Text + ";");
            this.Close();
        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Clipboard.SetText("return " + textBox1.Text + ";");
                this.Close();
            }
        }
    }
}
