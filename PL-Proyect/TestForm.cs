using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_Proyect
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void entryField_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHelloWorld_click(object sender, EventArgs e)
        {
            outputScreen.AppendText(">Hello World\n");
        }

        private void tbSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string userEntry = entryField.Text;
            entryField.Text = "";
            outputScreen.AppendText("You said: " + userEntry + "\n");
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string userEntry = entryField.Text;
                entryField.Text = "";
                outputScreen.AppendText("-" + userEntry + "\n");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm aboutForm = new aboutForm();
            aboutForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
