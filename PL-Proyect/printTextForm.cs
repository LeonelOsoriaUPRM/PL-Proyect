using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class printTextForm : Form
    {
        public printTextForm()
        {
            InitializeComponent();
        }

        private void printTextForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.printTextForm = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Clipboard.SetText("ConsoleWrite(" + s + ");");
            this.Close();
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string s = textBox1.Text;
                Clipboard.SetText("ConsoleWrite(" + s + ");");
                this.Close();
            }
        }
    }
}
