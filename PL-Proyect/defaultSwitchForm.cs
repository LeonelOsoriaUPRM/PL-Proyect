using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class defaultSwitchForm : Form
    {
        public defaultSwitchForm()
        {
            InitializeComponent();
        }

        private void defaultSwitchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.defaultSwitchForm = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("default:\n\t\t\t//Place code for default case here\n\t\t\t\t\n\t\t\tbreak;");
            this.Close();
        }
    }
}
