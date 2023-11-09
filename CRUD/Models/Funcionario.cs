using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Column("ID")]
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Column("Cargo")]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }
        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Column("Responsabilidades")]
        [Display(Name = "Responsabilidades")]
        public string Responsabilidades { get; set; }
       
    }
}
