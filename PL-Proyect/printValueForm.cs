﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class printValueForm : Form
    {
        public printValueForm()
        {
            InitializeComponent();
        }

        private void printValueForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.printValueForm = null;
        }
    }
}