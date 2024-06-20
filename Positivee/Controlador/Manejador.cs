public  class  Manejador(){
    private static Conexion conexion=new Conexion();
    private Conexion db=new Conexion();


    public void _add(string query){
           //SQL que ejecutara Dapper, aquí puedes jugar con los orders que quieras.
            string sql = @"";
            //Ejecutar la consulta SQL y almacenar las líneas en nuestro modelo. 
            var catQuery = db.Query<Categoria>(sql);
    }
    public return var _load(string query,var modelo){
           //SQL que ejecutara Dapper, aquí puedes jugar con los orders que quieras.
            string sql = @+query;
            //Ejecutar la consulta SQL y almacenar las líneas en nuestro modelo. 
            try{
                db.Open();
                var catQuery = db.Query<modelo>(sql);
                db.close();
                }
            catch(Exception ex){
                
                    MessageBox.Show("No se pudo cargar datos" + ex);
            }
            return catQuery;
    }
}