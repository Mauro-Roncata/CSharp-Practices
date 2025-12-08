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
using System.Data.SQLite;
using MySql.Data.MySqlClient;

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

            #region SQL Server CE
            /*
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
            }*/
            #endregion

            #region SQLite 
            /*
            string baseDados = Application.StartupPath + "\\db\\DBSQLite.db";
            string strConnection = $@"Data Source = {baseDados}; Version = '3'";


            if (!File.Exists(baseDados))
            {
                SQLiteConnection.CreateFile(baseDados);
            }

            SQLiteConnection connect = new SQLiteConnection(strConnection);

            try
            {
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
            }*/
            #endregion

            #region MySQL
            string strConnection = "server=127.0.0.1;User ID=root;password=051022";

            MySqlConnection connect = new MySqlConnection(strConnection);

            try
            {
                connect.Open();
                lblResult.Text = "Conectado";

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connect;
                comando.CommandText = "CREATE DATABASE IF NOT EXISTS db_teste";

                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex) 
            {
                lblResult.Text = $"Erro:{ex.Message}";
            }
            finally
            { 
                connect.Close(); 
            }

            #endregion

        }
    }
}
