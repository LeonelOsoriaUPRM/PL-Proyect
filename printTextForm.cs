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
            Clipboard.SetText("Console.Write(" + textBox1.Text + ");\n\t\t\tConsole.Read();");
            this.Close();
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Clipboard.SetText("ConsoleWrite(" + textBox1.Text + ");\n\t\t\tConsole.Read();");
                this.Close();
            }
        }
    }
}
