using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_CRUD.Models
{
    [Table("Cliente")]
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nome obrigatório!")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email Obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Senha Obrigatória!")]
        public int Password { get; set; }

    }
}
