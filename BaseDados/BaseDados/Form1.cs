using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            /*
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
            */
            #endregion

        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            #region SQLServerCE
            /*
            string baseDados = Application.StartupPath + "\\db\\dbSQLServer.sdf";
            string strConnection = $@"DataSource = {baseDados}; Password = '123'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            SqlCeEngine db = new SqlCeEngine(strConnection);
            if (!File.Exists(baseDados))
            {
                db.CreateDatabase();
            }
            db.Dispose();

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE pessoas(id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
                lblResult.Text = "Tabela Criada";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Erro: {ex.Message}";
            } 
            finally   
            { 
                conexao.Close(); 
            }*/

            #endregion

            #region SQLiteTABLE
            /*
            string baseDados = Application.StartupPath + "\\db\\DBSQLite.db";
            string strConnection = $@"Data Source = {baseDados}; Version = '3'";

            SQLiteConnection conexao = new SQLiteConnection(strConnection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE pessoas(id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
                lblResult.Text = "Tabela Criada";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Erro: {ex.Message}";
            }
            finally
            {
                conexao.Close();
            }
            */
            #endregion

            #region MySQLTABLE
            /*
            string strConnection = "server=127.0.0.1;User ID=root;database=db_teste;password=051022";

            MySqlConnection connect = new MySqlConnection(strConnection);

            try
            {
                connect.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connect;

                comando.CommandText = "CREATE TABLE pessoas(id INT NOT NULL, nome VARCHAR(50), email VARCHAR(50), PRIMARY KEY(id))";
                lblResult.Text = "Tabela Criada";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Erro: {ex.Message}";
            }
            finally
            {
                connect.Close();
            }*/
            #endregion
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            #region SQLServerCEInsert
            string baseDados = Application.StartupPath + "\\db\\dbSQLServer.sdf";
            string strConnection = $@"DataSource = {baseDados}; Password = '123'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            SqlCeEngine db = new SqlCeEngine(strConnection);
            if (!File.Exists(baseDados))
            {
                db.CreateDatabase();
            }
            db.Dispose();

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0,1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = "INSERT INTO pessoas VALUES ("+id+", ' "+nome+" ', ' "+email+" ')";
                comando.ExecuteNonQuery();
                lblResult.Text = "Registro inserido";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Erro: {ex.Message}";
            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }
    }
}
