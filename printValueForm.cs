using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BabyCsharpProject
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
            string t0 = "";
            bool a = true;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    a = true;
                    t = "string ";
                    break;

                case 1:
                    a = true;
                    t = "bool ";
                    break;

                case 2:
                    a = true;
                    t = "int ";
                    break;

                case 3:
                    a = true;
                    t = "double ";
                    break;

                default:
                    a = false;
                    label1.Visible = true;
                    label1.Text = "Please select a variable type";
                    break;
            }

            if (textBox1.Text == string.Empty)
            {
                label1.Visible = true;
                label1.Text = "Please provide a name to the variable";
                a = false;
            }

            else if (a)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        TestForm.userVariables.Add(textBox1.Text);
                        Clipboard.SetText(t + textBox1.Text + " = Console.ReadLine();");
                        this.Close();
                        break;

                    case 1:
                        TestForm.userVariables.Add(textBox1.Text);
                        Clipboard.SetText(t + textBox1.Text + " = Convert.ToBoolean(Console.ReadLine());");
                        this.Close();
                        break;
                        
                    case 2:
                        TestForm.userVariables.Add(textBox1.Text);
                        Clipboard.SetText(t + textBox1.Text + " = Convert.ToInt32(Console.ReadLine());");
                        this.Close();
                        break;

                    case 3:
                        TestForm.userVariables.Add(textBox1.Text);
                        Clipboard.SetText(t + textBox1.Text + " = Convert.ToDouble(Console.ReadLine());");
                        this.Close();
                        break;

                    default:
                        TestForm.userVariables.Add(textBox1.Text);
                        Clipboard.SetText(t + textBox1.Text + " = Console.ReadLine();");
                        this.Close();
                        break;
                }
            }
        }
    }
}
