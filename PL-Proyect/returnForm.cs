﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class returnForm : Form
    {
        public returnForm()
        {
            InitializeComponent();
        }

        private void returnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.returnForm = null;
        }
    }
}