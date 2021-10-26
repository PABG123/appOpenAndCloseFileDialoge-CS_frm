using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace appOpenAndCloseFileDialoge_CS_frm
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader Reader = new StreamReader(@"F:\Test.txt"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox1.AppendText(Reader.ReadLine());
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter Writer = new StreamWriter(@"F:\Test.txt"))
            {
                Writer.WriteLine(richTextBox1.Text);
            }
        }
    }
}
