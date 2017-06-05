using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanMonopoly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        delegate void StringArgReturningVoidDelegate(string text);
        public void ConsoleWriteln(string text)
        {
            if (this.Console_Console.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(ConsoleWriteln);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                Console_Console.AppendText(text + "\n");
            }
        }

        private void Console_CommandBtn_Click(object sender, EventArgs e)
        {
            ConsoleReadln(Console_InputBox.Text);
        }

        private void Console_InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ConsoleReadln(Console_InputBox.Text);
            }
        }

        public void ConsoleReadln(string text)
        {
            Console_InputBox.Text = "";
            string data = text.ToLowerInvariant();
            string[] segments = data.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            switch (segments[0])
            {
                case "startgame":  break;
                default: ConsoleWriteln("- " + text); break;
            }
        }
    }
}
