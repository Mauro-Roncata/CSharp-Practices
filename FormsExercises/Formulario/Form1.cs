using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            Hide();
            FormSecond sec = new FormSecond("Olá Mundo");
            //sec.Mensagem = "Olá mundo";
            sec.ShowDialog();
            if (sec != null)
            {
                lblTitulo.Text = sec.Mensagem;
            }
            Show();
        }

        private void btnSECFORM_Click(object sender, EventArgs e)
        {

            Close();
            Thread t = new Thread(()=> Application.Run(new FormSecond()));
            t.Start();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mFileNovo_Click(object sender, EventArgs e)
        {
            new Thread (() => Application.Run(new FormMain())).Start();
        }

        private void mFileAbrir_Click(object sender, EventArgs e)
        {
            Hide();
            FormSecond f = new FormSecond();
            f.ShowDialog();
            Show();
        }

        private void mSobreDev_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Mauro Roncata", "Desenvolvedor: ");
        }

        private void mSobreVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0", "Versão: ");
        }

        private void comboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMenu.SelectedIndex == 0)
            {
                MenuFile.Text = "File";
                MenuHelp.Text = "Help";
            }
            else if (comboMenu.SelectedIndex == 1)
            {
                MenuFile.Text = "Arquivo";
                MenuHelp.Text = "Ajuda";
            } 
            else if (comboMenu.SelectedIndex == 2)
            {
                MenuFile.Text = "Arriba!";
                MenuHelp.Text = "Ayudame";
            }
        }

        private void mPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                lblTitulo.Text = mPesquisar.Text;
                mPesquisar.Text = "";
            }
        }
    }
}
