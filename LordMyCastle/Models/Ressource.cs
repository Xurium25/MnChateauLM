using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class Ressource
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Production Horaire"), Range(0, 10000000, ErrorMessage = "La production saisie n'est pas valide")]
        public int Production { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Stocks en sac"), Range(0, 10000000, ErrorMessage = "Vous devez rentrer la valeur en milliers")]
        public int Stock { get; set; }
    }
}