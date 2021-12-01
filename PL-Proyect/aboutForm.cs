using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void aboutTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void aboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.aboutFrom = null;
        }
    }
}
