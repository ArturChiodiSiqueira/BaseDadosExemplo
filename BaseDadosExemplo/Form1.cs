using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// SQL Server CE
using System.Data.SqlServerCe;
// SQLite
using System.Data.SQLite;
// MySQL
using MySql.Data.MySqlClient;

namespace BaseDadosExemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            #region SQL SERVER CE
            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSourse = " + baseDados + "; Password = '1234'";

            //SqlCeEngine db = new SqlCeEngine(strConection);

            //if (!File.Exists(baseDados))
            //{
            //    db.CreateDatabase();
            //}
            //db.Dispose();

            //SqlCeConnection conexao = new SqlCeConnection(strConection);

            //try
            //{
            //    conexao.Open();
            //    labelResultado.Text = "Conectado Sql Server CE";
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro ao Conectar Sql Server CE \n" + ex;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Sourse = " + baseDados + "; Version = 3";

            if (!File.Exists(baseDados))
            {
                SQLiteConnection.CreateFile(baseDados);
            }

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            conexao.ConnectionString = strConection;

            try
            {
                conexao.Open();
                labelResultado.Text = "Conectado SQLite";
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao Conectar SQLite \n" + ex;
            }
            finally
            {
                conexao.Close();
            }
            #endregion

            #region MySQL

            #endregion
        }
    }
}