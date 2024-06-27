using System.ComponentModel.DataAnnotations;

namespace FILMESV3.Models
{
    public class FilmesModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do Filme!")]
        public string? Filme { get; set; }

       



    }
}