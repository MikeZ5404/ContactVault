using System.ComponentModel.DataAnnotations;

namespace ContactVault.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public string Apellido { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Empresa { get; set; } = string.Empty;
    }
}