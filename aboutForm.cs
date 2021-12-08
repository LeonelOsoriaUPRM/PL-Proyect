using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BabyCsharpProject
{
    public partial class aboutForm : Form
    {
        //Final Commit for Grading
        public aboutForm()
        {
            InitializeComponent();
        }

        private void aboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.aboutFrom = null;
        }
    }
}
