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

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            lblResult.Text = TimeSpan.FromDays(2.55).ToString(); ;

            TimeSpan ts = new TimeSpan(5,30,30);

            lblResult.Text = ts.ToString(); ;
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            // DateTime agora = DateTime.Now;
            // DateTime agora = DateTime.Today;
            // DateTime.DaysInMonth(2020,07);
            // bool agora = DateTime.IsLeapYear(2024);
            // string agora = DateTime.Now.ToLongDateString();
            // string agora = DateTime.Now.ToShortDateString();
            // string agora = DateTime.Now.ToLongTimeString();
            // string agora = DateTime.Now.ToShortTimeString();
            // DateTime agora = DateTime.Now.ToUniversalTime();
            // DateTime agora = DateTime.Now;
            // lblResult.Text = agora.ToString("dd-MM-yyyy HH:mm:ss"); 


            DateTime data = new DateTime(1985, 01, 10, 14, 20, 0);

           /* TimeSpan tempo = new TimeSpan(5,30,30);
            lblResult.Text = data.Add(tempo).ToString();*/

            lblResult.Text = data.DayOfWeek.ToString(); 
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Color aqua = Color.Aqua;
            Color bisque = Color.Khaki;

            // Color cor1 = Color.FromArgb(100, aqua);
            Color cor1 = Color.FromArgb(255, 255, 255, 255);
            Color cor2 = Color.FromKnownColor(KnownColor.DarkViolet);
            Color cor3 = Color.FromName("DarkRed");

            lblResult.BackColor = cor3;
            lblResult.ForeColor = bisque;

            Color cor4 = lblResult.BackColor;

            btnColor.ForeColor = cor4;
            

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            Font letra = new Font("Arial",36,FontStyle.Regular, GraphicsUnit.Pixel);
            lblResult.Text = "Bem vindo ao c#, fontes";

            lblResult.Font = letra;
        }

        private void btnEnviroment_Click(object sender, EventArgs e)
        {
            string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            lblResult.Text = myDocs;
        }
    }
}
