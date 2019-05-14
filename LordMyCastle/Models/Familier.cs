using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class Familier
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Range(1, 60, ErrorMessage = "Le niveau du familier est obligatoirement compris entre 1 et 60")]
        public int Niveau { get; set; }
        public List<CompetenceFamilier> Competences { get; set; }
    }
}