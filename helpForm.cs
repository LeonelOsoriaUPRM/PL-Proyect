using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BabyCsharpProject
{
    public partial class helpForm : Form
    {
        public helpForm()
        {
            InitializeComponent();
        }

        private void helpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.helpForm = null;
        }
    }
}
