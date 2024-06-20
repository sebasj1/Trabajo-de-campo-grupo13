public  class Conexion(){
    private static string _connectionString = "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";
    private static  var db=null;
    private bool estado=false;
        public static bool iniciar(){
          //Iniciar la conexión con la base de datos
            db = new MySqlConnector.MySqlConnection(_connectionString);
            if(db.Open()){
               estado=true;
            } 
            else{
                estado=false;
            }
            return estado;
            }
        public static bool cerrar(){
          //Iniciar la conexión con la base de datos
            if(db.Close()){
                estado=true;
            }else{
                estado=false;
            }
            return estado;
            }
    }