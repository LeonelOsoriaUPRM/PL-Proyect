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
    }
}
