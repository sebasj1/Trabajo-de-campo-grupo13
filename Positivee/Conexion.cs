

using Dapper;
using System.Data;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public static  class Conexion{

    private static string _connectionString= "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";
    public static void conectar(string p_server, string p_Database, string p_User, string p_pass){
         //_connectionString = "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";
        /*

        _connectionString += "Server="+p_server;
  _connectionString+=";Database="+p_Database;
   _connectionString+=";User Id="+p_User;
   _connectionString+=";Password="+p_pass+";";*/

      
    }  
    private static  void FINDCONECTION()
        {
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var conection = db.QueryFirst(
                           sql: "search_conection",
                           param:new{ },
                           commandType: CommandType.StoredProcedure
                );
                _connectionString = conection.server + ";" +
                    conection.satabase + ";" + conection.user + ";" + conection.password + ";";
            }
        }
  public static string get_string(){
       
            // FINDCONECTION();
        
        
return _connectionString;
  }}