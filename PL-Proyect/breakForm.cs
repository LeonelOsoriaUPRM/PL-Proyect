using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class breakForm : Form
    {
        public breakForm()
        {
            InitializeComponent();
        }

        private void breakForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.breakForm = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("break;");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
