using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class printTextForm : Form
    {
        public printTextForm()
        {
            InitializeComponent();
        }

        private void printTextForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.printTextForm = null;
        }
    }
}
