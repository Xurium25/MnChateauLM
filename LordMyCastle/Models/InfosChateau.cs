using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class InfosChateau
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "La puissance doit être obligatoirement saisie"), Range(1, 2000000000, ErrorMessage = "Accepte valeur entre 1 et 2.000.000.000")]
        public int Puissance { get; set; }
        [Required(ErrorMessage = "Le nombre de kills doit être saisi"), Range(0, 2000000000, ErrorMessage = "Accepte valeur entre 1 et 2.000.000.000")]
        public int Kills { get; set; }
        [Required(ErrorMessage = "Veuillez renseigner le niveau VIP"), Range(1, 15, ErrorMessage = "Le niveau VIP est compris entre 1 et 15")]
        public int VIP { get; set; }
        [Required(ErrorMessage = "Veuillez renseigner le niveau du château"), Display(Name = "Niveau du Château"), Range(1, 25, ErrorMessage = "Le niveau du château doit être compris entre 1 et 25")]
        public int NiveauChateau { get; set; }
        [Required(ErrorMessage = "Veuillez renseigner le niveau du héros"), Display(Name = "Niveau du Héros"), Range(1, 60, ErrorMessage = "Le niveau doit être compris entre 12 et 60")]
        public int NiveauHeros { get; set; }
    }
}