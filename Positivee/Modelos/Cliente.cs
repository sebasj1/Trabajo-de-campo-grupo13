
namespace Positive
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Cliente
    {


        public int id_cliente { get; set; }
        public int id_persona { get; set; }
        public int id_estado { get; set; }

    }
}
