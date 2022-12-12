using System.ComponentModel.DataAnnotations;

namespace ProyectoP2_CatalogoV1.Model
{
    internal class User
    {
        [Required]
        private string NombreUsuario { get; set; }
        [Required]
        private string Contrasenia { get; set; }
        [Required]
        private string Telefono { get; set; }

        public string Filename { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

    }
}
