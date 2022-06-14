using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        [StringLength(255, ErrorMessage = "O campo diretor não deve ter mais de 255 caracteres")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "O campo genêro não deve passar de 30 caracteres")]
        public string Genero { get; set; }
        
        [Range(1, 600)]
        public int Duracao { get; set; }
    }
}
