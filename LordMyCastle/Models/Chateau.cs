using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class Chateau
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le nom du château doit être renseigné"), Display(Name = "Nom du château"), MinLength(2, ErrorMessage = "Le nom doit comporter au moins 2 caractère"), MaxLength(20, ErrorMessage = "Le nom du château doit être composé de moins de 20 caractères")]
        public string Nom { get; set; }

        public virtual List<InfosChateau> InfosChateau { get; set; }
        public virtual List<Troupes> Troupes { get; set; }

        public virtual List<Ressource> Ressources { get; set; }
        public virtual List<Batiment> Batiments { get; set; }
        public virtual List<Hero> Heros { get; set; }
        public virtual List<Recherche> Recherches { get; set; }
        public virtual List<Familier> Familiers { get; set; }
        public virtual List<Equipement> Equipements { get; set; }
        public virtual List<StatsMono> StatsMonos { get; set; }
        public virtual List<StatsDuo> StatsDuos { get; set; }
        public virtual StatsMixte StatsMixte { get; set; }
    }
}