using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class Equipement
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Couleur { get; set; }

        public virtual Joyau Joyau1 { get; set; }
        public virtual Joyau Joyau2 { get; set; }
        public virtual Joyau Joyau3 { get; set; }
    }
}