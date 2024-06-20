

namespace Positive
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Persona
    {
        
    
        public int id_persona { get; set; }
        public int id_contacto { get; set; }

        [Required(ErrorMessage = "El nombre  es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre  debe tener como máximo 50 caracteres.")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatoria.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El apellido debe tener entre 6 y 100 caracteres.")]
        public string apellido { get; set; }
        public int id_tipo_documento { get; set; }
        public string numero_documento { get; set; }

    }
}
