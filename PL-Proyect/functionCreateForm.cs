﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class functionCreateForm : Form
    {
        public functionCreateForm()
        {
            InitializeComponent();
        }

        private void functionCreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.functionCreateForm = null;
        }
    }
}