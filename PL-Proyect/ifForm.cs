using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class ifForm : Form
    {
        public ifForm()
        {
            InitializeComponent();
        }

        private void ifForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.ifForm = null;
        }
    }
}
