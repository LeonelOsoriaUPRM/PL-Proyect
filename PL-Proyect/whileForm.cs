using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class whileForm : Form
    {
        public whileForm()
        {
            InitializeComponent();
        }

        private void whileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.whileForm = null;
        }
    }
}
