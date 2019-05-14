using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class Recherche
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le niveau de la recherche doit être renseigné!"), Display(Name = "Niveau de la recherche")]
        public int Niveau { get; set; }
        [Required]
        public string Categorie { get; set; }
    }
}