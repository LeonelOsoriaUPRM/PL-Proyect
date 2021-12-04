using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class variableForm : Form
    {
        public variableForm()
        {
            InitializeComponent();
        }

        private void variableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.variableForm = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkSelection();
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                checkSelection();
            }
        }

        private void checkSelection()
        {
            string t = "";
            bool a = true;

            if (textBox1.Text == string.Empty)
            {
                label3.Text = "Please provide a name to the variable";
                a = false;
            }

            switch (comboBox1.SelectedIndex)
            {   
                case 0:
                    //label3.Text = "0";
                    t = "string ";
                    if (textBox2.Text != String.Empty)
                    {
                        if (!textBox2.Text.Contains("\""))
                        {
                            textBox2.Text = "\""+textBox2.Text+"\"";
                        }
                    }
                    break;
                    
                case 1:
                    //label3.Text = "1";
                    t = "bool ";
                    if (textBox2.Text != String.Empty)
                    {
                        if (!bool.TryParse(textBox2.Text, out _))
                        {
                            label3.Text = "Your input isn't valid as a boolean";
                            a = false;
                        }
                        else
                        {
                            a = true;
                        }
                    }
                    break;

                case 2:
                    //label3.Text = "2";
                    t = "int ";
                    if (textBox2.Text != String.Empty)
                    {
                        if (!int.TryParse(textBox2.Text, out _))
                        {
                            label3.Text = "Your input isn't valid as a int";
                            a = false;
                        }
                        else
                        {
                            a = true;
                        }
                    }
                    break;

                case 3:
                    //label3.Text = "3";
                    t = "double ";
                    if (textBox2.Text != String.Empty)
                    {
                        if (!double.TryParse(textBox2.Text, out _))
                        {
                            label3.Text = "Your input isn't valid as a double";
                            a = false;
                        }
                        else
                        {
                            a = true;
                        }
                    }
                    break;

                default:
                    label3.Text = "Please select a variable type";
                    a = false;
                    break;
            }

            if(textBox2.Text == string.Empty && a)
            {
                if(t == "string ")
                {
                    Clipboard.SetText(t + textBox1.Text + " = \"\";");
                    this.Close();
                }
                else
                {
                    Clipboard.SetText(t + textBox1.Text + ";");
                    this.Close();
                }

            }

            else if(!(textBox1.Text == string.Empty) && !(textBox2.Text == string.Empty) && a)
            {
                Clipboard.SetText(t + textBox1.Text + " = " + textBox2.Text+";");
                this.Close();
            }
        }
    }
}
