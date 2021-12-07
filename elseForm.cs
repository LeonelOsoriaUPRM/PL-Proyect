using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BabyCsharpProject
{
    public partial class elseForm : Form
    {
        public elseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("else\n\t\t\t{\n\t\t\t\t//place your \"else\" code here\n\t\t\t\t\n\t\t\t}");
            this.Close();
        }

        private void elseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.elseForm = null;
        }
    }
}
