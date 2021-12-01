using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class forForm : Form
    {
        public forForm()
        {
            InitializeComponent();
        }

        private void forForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.forForm = null;
        }
    }
}
