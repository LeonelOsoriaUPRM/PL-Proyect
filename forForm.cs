using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BabyCsharpProject
{
    public partial class forForm : Form
    {
        public forForm()
        {
            InitializeComponent();
        }

        private void forForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.forForm = null;
        }

        private void forForm_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("for( " + textBox4.Text + " ; " + textBox3.Text + " ; " + textBox5.Text + " )\n\t\t\t{\n\t\t\t\t//Place code to be looped here\n\t\t\t\t\n\t\t\t}");
            this.Close();
        }

        private void CheckEnterKeyPress1(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Clipboard.SetText("for( " + textBox4.Text + " ; " + textBox3.Text + " ; " + textBox5.Text + " )\n\t\t\t{\n\t\t\t\t//Place code to be looped here\n\t\t\t\t\n\t\t\t}");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            button3.Visible = true;
            errorLabel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forCheck();
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                forCheck();
            }
        }
        private void forCheck()
        {
            bool er = false;
            string t0 = "";
            string t1 = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    t0 = "<= ";
                    break;

                case 1:
                    t0 = ">= ";
                    break;

                case 2:
                    t0 = "< ";
                    break;

                case 3:
                    t0 = "> ";
                    break;

                case 4:
                    t0 = "== ";
                    break;

                case 5:
                    t0 = "!= ";
                    break;

                default:
                    errorLabel1.Text = "Please select a comparison operator";
                    er = true;
                    break;
            }

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    t1 = "++ ";
                    break;

                case 1:
                    t1 = "-- ";
                    break;

                default:
                    errorLabel1.Text = "Please select + or -";
                    er = true;
                    break;
            }

            if (textBox1.Text == string.Empty || !int.TryParse(textBox1.Text, out _))
            {
                errorLabel1.Text = "Please initialize i with an integer";
                er = true;
            }

            if (textBox2.Text == string.Empty || !int.TryParse(textBox2.Text, out _))
            {
                errorLabel1.Text = "Please enter an integer for the limit condition";
                er = true;
            }

            else if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && !er)
            {
                Clipboard.SetText("for( int i = "+ textBox1.Text + " ; i " + t0 + textBox2.Text + " ; i"  + t1 + ")\n\t\t\t{\n\t\t\t\t//Place code to be looped here\n\t\t\t\t\n\t\t\t}");
                this.Close();
            }
            else
            {
                er = false;
            }
        }
    }
}
