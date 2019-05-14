using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class Troupes
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Infanterie T1"), Range(0, 2000000000)]
        public int InfanterieT1 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Archer T1"), Range(0, 2000000000)]
        public int ArcherT1 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Cavalerie T1"), Range(0, 2000000000)]
        public int CavalerieT1 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Engin de Siège T1"), Range(0, 2000000000)]
        public int EnginSiegeT1 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Infanterie T2"), Range(0, 2000000000)]
        public int InfanterieT2 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Archer T2"), Range(0, 2000000000)]
        public int ArcherT2 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Cavalerie T2"), Range(0, 2000000000)]
        public int CavalerieT2 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Engin de Siège T2"), Range(0, 2000000000)]
        public int EnginSiegeT2 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Infanterie T3"), Range(0, 2000000000)]
        public int InfanterieT3 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Archer T3"), Range(0, 2000000000)]
        public int ArcherT3 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Cavalerie T3"), Range(0, 2000000000)]
        public int CavalerieT3 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Engin de Siège T3"), Range(0, 2000000000)]
        public int EnginSiegeT3 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Infanterie T4"), Range(0, 2000000000)]
        public int InfanterieT4 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Archer T4"), Range(0, 2000000000)]
        public int ArcherT4 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Cavalerie T4"), Range(0, 2000000000)]
        public int CavalerieT4 { get; set; }
        [Required(ErrorMessage = "Le champ doit être renseigné"), Display(Name = "Engin de Siège T4"), Range(0, 2000000000)]
        public int EnginSiege { get; set; }
    }
}