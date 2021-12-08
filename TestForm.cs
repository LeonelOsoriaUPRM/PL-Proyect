using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Microsoft.CSharp;
using System.IO;

//There's a few invisible items on this form because it was easier to make then inaccessible was easier and faster than removing them

namespace BabyCsharpProject
{
    public partial class TestForm : Form
    {
        bool c = false;
        string Output = "";

        public static List<string> userVariables = new List<string> { };

        public static placeholderForm placeholderForm = null;
        public static aboutForm aboutFrom = null;
        public static breakForm breakForm = null;
        public static caseForm caseForm = null;
        public static elseForm elseForm = null;
        public static forForm forForm = null;
        public static functionCreateForm functionCreateForm = null;
        public static helpForm helpForm = null;
        public static ifForm ifForm = null;
        public static mathForm mathForm = null;
        public static printTextForm printTextForm = null;
        public static printValueForm printValueForm = null;
        public static returnForm returnForm = null;
        public static switchForm switchForm = null;
        public static variableForm variableForm = null;
        public static whileForm whileForm = null;
        public static defaultSwitchForm defaultSwitchForm = null;

        public TestForm()
        {
            InitializeComponent();
            codeInTextPanel.EnableContextMenu();
            ConsoleWrite("Click the \"help\" tab for instructions on how this program works");
            ConsoleWrite("Click the \"example\" tab to see example programs");
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button1_Click);
        }

        private void tbHelloWorld_click(object sender, EventArgs e)
        {
            codeInTextPanel.Text = "using System;\n\nnamespace LearningSpace\n{\n\tstatic class Program\n\t{\n\t\tstatic void Main(string[] args)\n\t\t{\n\t\t\t//Your code goes here!\n\t\t\tConsole.WriteLine(\"Hello World\\n\");\n\t\t\tConsole.ReadLine();\n\t\t}\n\t}\n}";
        }

        private void tbSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (StreamWriter streamWriter = new StreamWriter(s))
                {
                    streamWriter.Write(codeInTextPanel.Text);
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            UserWrite(entryField.Text);
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                UserWrite(entryField.Text);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm aboutForm = new aboutForm();
            aboutForm.Show();
        }

        private void tbHelp_Click(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            help.Show();
        }

        private void defaultCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeInTextPanel.Text = "using System;\n\nnamespace LearningSpace\n{\n\tstatic class Program\n\t{\n\t\tstatic void Main(string[] args)\n\t\t{\n\t\t\t//Your code goes here!\n\t\t\t\n\t\t\tConsole.ReadLine();//This will output any Console.WriteLine commands in the code\n\t\t}\n\t}\n}";
        }

        //Custom functions start

        private void ConsoleWrite(string s)
        {
            outputScreen.ForeColor = Color.Green;
            s = ">" + s;
            outputScreen.AppendText(s + "\n");
        }

        private void UserWrite(string s)
        {
            outputScreen.ForeColor = Color.Red;
            s = "-" + s;
            outputScreen.AppendText(s + "\n");
            entryField.Text = "";
        }

        //Custom functions end

        private void printTextBt_Click(object sender, EventArgs e)
        {
            if (printTextForm == null)
            {
                printTextForm = new printTextForm();
                printTextForm.Show();
            }
            else
            {
                printTextForm.BringToFront();
            }
        }


        private void printValuebtn_Click(object sender, EventArgs e)
        {
            if (printValueForm == null)
            {
                printValueForm = new printValueForm();
                printValueForm.Show();
            }
            else
            {
                printValueForm.BringToFront();
            }
        }

        private void variableSetbt_Click(object sender, EventArgs e)
        {
            if (variableForm == null)
            {
                variableForm = new variableForm();
                variableForm.Show();
            }
            else
            {
                variableForm.BringToFront();
            }
        }

        private void mathbt_Click(object sender, EventArgs e)
        {
            if (mathForm == null)
            {
                mathForm = new mathForm();
                mathForm.Show();
            }
            else
            {
                mathForm.BringToFront();
            }
        }

        private void ifbt_Click(object sender, EventArgs e)
        {
            if (ifForm == null)
            {
                ifForm = new ifForm();
                ifForm.Show();
            }
            else
            {
                ifForm.BringToFront();
            }
        }

        private void elsebt_Click(object sender, EventArgs e)
        {
            if (elseForm == null)
            {
                elseForm = new elseForm();
                elseForm.Show();
            }
            else
            {
                elseForm.BringToFront();
            }
        }

        private void whilebt_Click(object sender, EventArgs e)
        {
            if (whileForm == null)
            {
                whileForm = new whileForm();
                whileForm.Show();
            }
            else
            {
                whileForm.BringToFront();
            }
        }

        private void forbt_Click(object sender, EventArgs e)
        {
            if (forForm == null)
            {
                forForm = new forForm();
                forForm.Show();
            }
            else
            {
                forForm.BringToFront();
            }
        }

        private void switchbt_Click(object sender, EventArgs e)
        {
            if (switchForm == null)
            {
                switchForm = new switchForm();
                switchForm.Show();
            }
            else
            {
                switchForm.BringToFront();
            }
        }

        private void casebt_Click(object sender, EventArgs e)
        {
            if (caseForm == null)
            {
                caseForm = new caseForm();
                caseForm.Show();
            }
            else
            {
                caseForm.BringToFront();
            }
        }

        private void breakbt_Click(object sender, EventArgs e)
        {
            if (breakForm == null)
            {
                breakForm = new breakForm();
                breakForm.Show();
            }
            else
            {
                breakForm.BringToFront();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (functionCreateForm == null)
            {
                functionCreateForm = new functionCreateForm();
                functionCreateForm.Show();
            }
            else
            {
                functionCreateForm.BringToFront();
            }
        }

        private void returnbt_Click(object sender, EventArgs e)
        {
            if (returnForm == null)
            {
                returnForm = new returnForm();
                returnForm.Show();
            }
            else
            {
                returnForm.BringToFront();
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (defaultSwitchForm == null)
            {
                defaultSwitchForm = new defaultSwitchForm();
                defaultSwitchForm.Show();
            }
            else
            {
                defaultSwitchForm.BringToFront();
            }
        }

        private void tbRun_Click(object sender, EventArgs e)
        {
            if (c)
            {
                Process.Start(Output);
            }
            else
            {
                ConsoleWrite("There's no succesfully built code to run");
            }
        }

        private void clearOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputScreen.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = codeInTextPanel.Text;
            //Stop Gap Solution, code from https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/compile-code-using-compiler
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            Output = "Out.exe";
            Button ButtonObject = (Button)sender;

            outputScreen.Text = "";
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            //Make sure we generate an EXE, not a DLL
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;
            CompilerResults results = icc.CompileAssemblyFromSource(parameters, textBox1.Text);

            if (results.Errors.Count > 0)
            {

                c = false;

                outputScreen.ForeColor = Color.Red;
                foreach (CompilerError CompErr in results.Errors)
                {
                    outputScreen.Text = outputScreen.Text +
                                "Line number " + CompErr.Line +
                                ", Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";" +
                                Environment.NewLine + Environment.NewLine;
                }
            }
            else
            {
                //Successful Compile
                outputScreen.ForeColor = Color.Blue;
                outputScreen.Text = "Success!";
                //If we clicked run then launch our EXE

                c = true;

                if (ButtonObject.Text == "Run") Process.Start(Output);
            }
            //Stop Gap Solution, code from https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/compile-code-using-compiler
        }

        private void buildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = codeInTextPanel.Text;
            //Stop Gap Solution, code from https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/compile-code-using-compiler
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            Output = "Out.exe";
            //Button ButtonObject = (Button)sender;

            outputScreen.Text = "";
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            //Make sure we generate an EXE, not a DLL
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;
            CompilerResults results = icc.CompileAssemblyFromSource(parameters, textBox1.Text);

            if (results.Errors.Count > 0)
            {
                //This code IS ours
                c = false;
                //This code IS ours
                outputScreen.ForeColor = Color.Red;
                foreach (CompilerError CompErr in results.Errors)
                {
                    outputScreen.Text = outputScreen.Text +
                                "Line number " + CompErr.Line +
                                ", Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";" +
                                Environment.NewLine + Environment.NewLine;
                    ConsoleWrite("Check for semicolons \"(;\"");
                    ConsoleWrite("Verify the placement of the code");
                    ConsoleWrite("Make sure all \"{\" have an equivalent \"}\"");
                }
            }
            else
            {
                //Successful Compile
                outputScreen.ForeColor = Color.Blue;
                outputScreen.Text = "Success!";
                //If we clicked run then launch our EXE
                //This code IS ours
                c = true;
                //This code IS ours
                //if (ButtonObject.Text == "Run") Process.Start(Output);
            }
            //Stop Gap Solution, code from https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/compile-code-using-compiler
        }

        private void tbOpen_Click(object sender, EventArgs e)
        {
            Stream stream;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openFileDialog.OpenFile()) != null)
                {
                    string filename = openFileDialog.FileName;
                    codeInTextPanel.Text = File.ReadAllText(filename);
                }
            }
        }

        private void tbNew_Click(object sender, EventArgs e)
        {
            codeInTextPanel.Text = "using System;\n\nnamespace LearningSpace\n{\n\tstatic class Program\n\t{\n\t\tstatic void Main(string[] args)\n\t\t{\n\t\t\t//Your code goes here!\n\t\t\t\n\t\t\tConsole.ReadLine();//This will output any Console.WriteLine commands in the code\n\t\t}\n\t}\n}";
        }
    }
}
