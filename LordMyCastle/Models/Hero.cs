using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class Hero
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Range(1, 60, ErrorMessage = "Le niveau du héros doit être compris entre 1 et 60")]
        public int Niveau { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Range(1, 8, ErrorMessage = "Le rang du héro doit être compris entre 1 et 8")]
        public int Rang { get; set; }
        [Required]
        public string Couleur { get; set; }
        [Display(Name = "Nombre de médailles"), Range(0, 150, ErrorMessage = "Il n'est pas possible d'avoir ce nombre de médailles")]
        public int? Medailles { get; set; }
    }
}