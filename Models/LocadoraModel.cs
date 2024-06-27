
using System.ComponentModel.DataAnnotations;
namespace LOCADORABASE.Models
{
    public class LocadoraModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do Cliente!")]
        public string Cliente { get; set; }
        
     
        public string FilmeEmprestado { get; set; }
        [Required(ErrorMessage = "Digite o nome do Filme!")]
        public DateTime DataEmprestimo { get; set; }

    }
}
