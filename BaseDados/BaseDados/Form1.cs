using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq.Expressions;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConect_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + "\\db\\dbSQLServer.sdf";
            string strConnection = $@"DataSource = {baseDados}; Password = '123'";

            SqlCeEngine db = new SqlCeEngine(strConnection);

            if (!File.Exists(baseDados))
            {
                db.CreateDatabase();
            }
            db.Dispose();

            SqlCeConnection connect = new SqlCeConnection(strConnection);

            try { 
            connect.Open();
            lblResult.Text = "Conectado";

            }
            catch (Exception ex)
            {
                lblResult.Text = "Erro ao conectar: " + ex.Message;
            }
            finally 
            { 
                connect.Close(); 
            }


        }
    }
}
