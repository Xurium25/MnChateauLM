using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class CompetenceFamilier
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public int Niveau { get; set; }
    }
}