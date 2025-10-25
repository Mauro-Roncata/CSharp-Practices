using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportantClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncMsgBox_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("Amo viver","como eu amo essa vida");
            DialogResult res = MessageBox.Show("Texto da mensagem", "Titulo", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                lblResult.Text = "SIM clicado";
                    }
            else if (res == DialogResult.No) 
            {
                lblResult.Text = "NO clicked";
            }*/

            MessageBox.Show("Mensagem","Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int valor = r.Next(0, 11);
            double valor2 = r.NextDouble() * 100;

            lblResult.Text = valor2.ToString();  
        }
    }
}
