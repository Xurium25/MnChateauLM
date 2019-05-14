using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class StatsMixte
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Attaque Infanterie"), Range(1, 800, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 800")]
        public int AttaqueInf { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Défense Infanterie"), Range(1, 400, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 400")]
        public int DefenseInf { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Pv Max Infanterie"), Range(1, 400, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 400")]
        public int PvMaxInf { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Attaque Archer"), Range(1, 800, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 800")]
        public int AttaqueArcher { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Défense Archer"), Range(1, 400, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 400")]
        public int DefenseArcher { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Pv Max Archer"), Range(1, 400, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 400")]
        public int PvMaxArcher { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Attaque Cavalerie"), Range(1, 800, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 800")]
        public int AttaqueCava { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Défense Cavalerie"), Range(1, 400, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 400")]
        public int DefenseCava { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Pv Max Cavalerie"), Range(1, 400, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 400")]
        public int PvMaxCava { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Attaque Armée"), Range(1, 300, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 300")]
        public int AttaqueArmee { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Défense Armée"), Range(1, 600, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 600")]
        public int DefenseArmee { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Pv Max Armée"), Range(1, 600, ErrorMessage = "Tu dois rentrer un chiffre entier entre 1 et 600")]
        public int PvMaxArmee { get; set; }
    }
}