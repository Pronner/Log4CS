using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Log4CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void terminal_TextChanged(object sender, EventArgs e)
        {



        }

        public string AfterReturn = "";

        private void terminal_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                if (terminal.Text == "help")
                {

                    MessageBox.Show("help, logstart, path (replace 'path' with an executable path to start)", "Commands", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    terminal.Clear();

                }
                else if (terminal.Text == "logstart")
                {

                    StartLogger.Start();
                    terminal.Clear();

                }
                else
                {

                    try
                    {


                        ProcessLog = terminal.Text;
                        Process.Start(terminal.Text);
                        terminal.Clear();

                        TextWriter textw = new StreamWriter("proclogger.log4cs", false);
                        textw.WriteLine("[" + DateTime.Now.ToString("t") + "] Started Process: " + ProcessLog);
                        textw.Close();

                    }
                    catch
                    {

                        MessageBox.Show("There was a problem starting this program... Please try again and verify the executable's location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        terminal.Clear();

                    }

                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        string ProcessLog = "";

        private string ReplaceAction = "";

        private void StartLogger_Tick(object sender, EventArgs e)
        {

            // Start logger

            if (ReplaceAction == "") // Replace this with another if statement to log whatever you're looking to log.
            {
                if (File.Exists("log4.cs"))
                {

                    TextWriter textw = new StreamWriter("logs.txt", false);
                    textw.WriteLine("Log something here.");
                    textw.Close();

                }
            }

        }
    }
}
