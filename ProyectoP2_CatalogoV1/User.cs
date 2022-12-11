using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP2_CatalogoV1
{
    internal class User
    {
        private int Id { get; set; }
        [Required]
        private String NombreUsuario { get; set; }
        [Required]
        private String Contrasenia { get; set; }
        [Required]
        private String Telefono { get; set; }

        public string Filename { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

    }
}
