using System.ComponentModel.DataAnnotations;

namespace CLIENTESV2.Models
{
    public class ClientesModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do Cliente!")]
        public string? Cliente { get; set; }

        [Required(ErrorMessage = "Digite o número do CPF!")]
        public int CPF { get; set; }
        
       

    }
}
