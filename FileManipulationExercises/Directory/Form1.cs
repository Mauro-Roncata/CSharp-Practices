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

namespace Directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Usuario\\source\\repos\\";

            bool res = System.IO.Directory.Exists(path + "pasta random");
            listBox1.Items.Add(res);
            /*
            if (!res)
            {
                System.IO.Directory.CreateDirectory(path + "pasta random");
            }
            
            if (res)
            {
                System.IO.Directory.Delete(path + "pasta random");
            }

            if (res)
            {
                System.IO.Directory.Move(path + "pasta random", path + "ArquivoPastas\\pasta random");
            }
            

            string[] dirs = System.IO.Directory.GetDirectories(path);

            foreach (string d in dirs)
            {
                listBox1.Items.Add(d);
            }
            */

            string[] dirs = System.IO.Directory.GetFiles(path);

            foreach (string f in dirs)
            {
                listBox1.Items.Add(f);
            }


        }
    }
}
