using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Usuario\\source\\repos\\file.txt";

            StreamWriter writer = new StreamWriter(path, true);

            writer.WriteLine(textBox1.Text);
            writer.Close();
        }
    }
}
