using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class StatsDuo
    {
        public int Id { get; set; }
        [Required]
        public string NomFormation { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Range(1, 800, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 800")]
        public int AttaqueTypeTroupe1 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Range(1, 400, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 400")]
        public int DefenseTypeTroupe1 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Range(1, 400, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 400")]
        public int PvMaxTypeTroupe1 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Range(1, 800, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 800")]
        public int AttaqueTypeTroupe2 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Range(1, 400, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 400")]
        public int DefenseTypeTroupe2 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Range(1, 400, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 400")]
        public int PvMaxTypeTroupe2 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Attaque Armée"), Range(1, 300, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 300")]
        public int AttaqueArmee { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Défense Armée"), Range(1, 600, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 600")]
        public int DefenseArmee { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Pv Max Armée"), Range(1, 600, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 600")]
        public int PvMaxArmee { get; set; }
    }
}