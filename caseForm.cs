using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BabyCsharpProject
{
    public partial class caseForm : Form
    {
        public caseForm()
        {
            InitializeComponent();
        }

        private void caseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.caseForm = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                Clipboard.SetText("default:\n\t\t\t//Place code for default case here\n\t\t\t\t\n\t\t\tbreak;");
                this.Close();
            }
            else
            {
                Clipboard.SetText("case " + textBox1.Text + ":\n\t\t\t//Place code for this case here\n\t\t\t\t\n\t\t\tbreak;");
                this.Close();
            }
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (textBox1.Text == string.Empty)
                {
                    Clipboard.SetText("default:\n\t\t\t//Place code for default case here\n\t\t\t\t\n\t\t\tbreak;");
                    this.Close();
                }
                else
                {
                    Clipboard.SetText("case " + textBox1.Text + ":\n\t\t\t//Place code for this case here\n\t\t\t\t\n\t\t\tbreak;");
                    this.Close();
                }
            }
        }
    }
}
