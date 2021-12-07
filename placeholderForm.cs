using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BabyCsharpProject
{
    public partial class placeholderForm : Form
    {
        public placeholderForm()
        {
            InitializeComponent();
        }

        private void placeholderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.placeholderForm = null;
        }
    }
}
