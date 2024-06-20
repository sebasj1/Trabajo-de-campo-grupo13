using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Positive.Presentacion;
using Positivee.Presentacion;
using System.Diagnostics.Contracts;

namespace Positive.Presentacion
{
    public partial class Form1 : Form
    {
        string _connectionString = Conexion.get_string(); //"Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {int v;
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                int LISTEXIST = db.ExecuteScalar<int>(
                           sql: "add_category",
                           param: new { @p_category = "a" },
                           commandType: CommandType.StoredProcedure
                );v = LISTEXIST;


                label1.Text = v.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string v;
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var LISTEXIST = db.ExecuteReader(
                           sql: "add_category",
                           param: new { @p_category = "a" },
                           commandType: CommandType.StoredProcedure
                ); v = LISTEXIST.ToString();


                label1.Text = v.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string v;
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var LISTEXIST = db.Execute(
                           sql: "add_category",
                           param: new { @p_category = "a" },
                           commandType: CommandType.StoredProcedure
                ); v = LISTEXIST.ToString();


                label1.Text = v.ToString();
            }
        }

        private void btEdUser_Click(object sender, EventArgs e)
        {
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {

                var queryAdd = db.ExecuteReader(
                                   sql: "edit_conection",
                                   param: new
                                   {
                                       @p_server = tbServer.Text,
                                       @p_database = tbDB.Text,
                                       @p_user = tbUser.Text,

                                       @p_password = tbPass.Text,
                                   },
                                   commandType: CommandType.StoredProcedure);

                }
            }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
