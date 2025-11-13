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

namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            string pasta = "C:\\Users\\Usuario\\source\\repos\\";
            string arquivo = "teste.txt";

            /* bool res = File.Exists(pasta + arquivo);
             lblResult.Text = res.ToString();

             File.Delete(pasta + arquivo);

             if (File.Exists(pasta + arquivo))
             {
               File.Copy(pasta + arquivo, pasta + "Copia.txt", true);
                 lblResult.Text = "Copiado";
             }
             else
             {
                 lblResult.Text = "Não existe";
             }*/

            //File.Move(pasta + arquivo, pasta + "Movido.txt");

            //File.Create(pasta + "teste.txt");

            File.WriteAllText(pasta + arquivo, "Testando WriteAll", Encoding.Default);


        }
    }
}
