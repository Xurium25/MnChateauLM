using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class Batiment
    {
        public int Id { get; set; }
        [Required]
        public string NomBatiment { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Range(1, 25, ErrorMessage = "Le niveau du batîment doit être compris entre 1 et 25")]
        public int Niveau { get; set; }
    }
}