﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class helpForm : Form
    {
        public helpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void helpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.helpForm = null;
        }
    }
}