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
        byte[] buffer;
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

        private void bt_ler_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            string path = "C:\\Users\\Usuario\\source\\repos\\file.txt";

            StreamReader reader = new StreamReader(path, Encoding.Default);
            /*string readTxt = reader.ReadToEnd();

            textBox1.Text = readTxt;
            */

            while (!reader.EndOfStream)
            {
        
                textBox1.Text += (char)reader.Read(); 

            }
            reader.Close();
        }

        private void btnLerBin_Click(object sender, EventArgs e)
        {
            FileStream fs = File.OpenRead("C:\\Users\\Usuario\\source\\repos\\file.txt");

            BinaryReader binReader = new BinaryReader(fs);

            /*while (binReader.BaseStream.Position != binReader.BaseStream.Length)
            {
                byte b = binReader.ReadByte();
                textBox1.Text += (char)b;
            }*/

            byte[] buffer = binReader.ReadBytes((int)binReader.BaseStream.Length);

           /*foreach (byte b in buffer)
            {
                textBox1.Text += (char)b;
            }

            binReader.Close();*/
        }

        private void btn_escrevBina_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Usuario\\source\\repos\\fileNew.txt";
            FileStream fs = File.OpenWrite(path);
            BinaryWriter binWriter = new BinaryWriter(fs);

            binWriter.Write(buffer);


            binWriter.Close();
        }
    }
}
