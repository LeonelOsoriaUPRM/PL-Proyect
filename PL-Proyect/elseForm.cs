using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class elseForm : Form
    {
        public elseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void elseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.elseForm = null;
        }
    }
}
