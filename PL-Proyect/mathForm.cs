using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class mathForm : Form
    {
        public mathForm()
        {
            InitializeComponent();
        }

        private void mathForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.mathForm = null;
        }
    }
}
