
namespace Positive
{
    using System;
    using System.Collections.Generic;
    
    public partial class Permiso
    {
        public int id_permiso { get; set; }
        public Nullable<int> id_rol { get; set; }
        public string descripcion { get; set; }
        public string nombreMenu { get; set; }
    }
}
