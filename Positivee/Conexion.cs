
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dapper;
using Positive;
using Positive.Presentacion;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySqlX.XDevAPI;
using System.Diagnostics.Contracts;

public static  class Conexion{

    private static string _connectionString= "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";
    public static void nueva_conexion(string p_server, string p_Database, string p_User, string p_pass){
        //_connectionString = "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";
        /*

        _connectionString += "Server="+p_server;
  _connectionString+=";Database="+p_Database;
   _connectionString+=";User Id="+p_User;
   _connectionString+=";Password="+p_pass+";";*/
       /*string server = p_server;
        string database = p_Database;
        string user = p_User;
        string p_password = p_pass;
        string conec = "Server="+p_server + ";Database=" + p_Database + ";User Id=" + p_User + ";Password=" + p_pass + ";";
        try
        {
            using (var db = new MySqlConnector.MySqlConnection(conec))
            {
                var conection = db.Execute(
                           sql: "set_conection",
                           param: new {
                              @p_server= p_server,
                               @p_database= p_Database,
                               @p_user= p_User,
                               @p_password= p_pass
                           },
                           commandType: CommandType.StoredProcedure
                );
                 }
            _connectionString = conec;
            FINDCONECTION();
        }
        catch (Exception e)
        {
            MessageBox.Show("No se puede conectar" + e);
        }*/

    }  
    public static  bool  FINDCONECTION()
        {/*
        bool ok = false;

        try
        {
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var conection = db.Query(
                           sql: "search_conection",
                           param: new { },
                           commandType: CommandType.StoredProcedure
                );
                var elementos = conection.ToList();
                _connectionString = elementos[0].server + ";" + elementos[0].database + ";" + elementos[0].user + ";" + elementos[0].password + ";";
            }ok = true;
        }
        catch(Exception e)
        {
            MessageBox.Show("No se puede conectar "+ e);
        }*/
        return true;
        }

    public static void actualizar_conexion()
    {
        FINDCONECTION();

    }
  public static string get_string(){
       
        
return _connectionString;
  }}