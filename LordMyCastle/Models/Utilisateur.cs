using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le pseudo est obligatoire"), MinLength(3, ErrorMessage = "Votre nom d'utilisateur doit comporter au moins 3 caractères"), MaxLength(20, ErrorMessage = "Votre nom d'utilisateur ne doit pas dépasser 20 caractères")]
        public string Pseudo { get; set; }
        [Required(ErrorMessage = "Vous n'avez pas saisie de mot de passe"), Display(Name = "Mot de passe")]
        public string Password { get; set; }
        public virtual List<Chateau> Chateaux { get; set; }
    }
}