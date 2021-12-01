using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class caseForm : Form
    {
        public caseForm()
        {
            InitializeComponent();
        }

        private void caseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.caseForm = null;
        }
    }
}
