using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LordMyCastle.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Batiment> Batiments { get; set; }
        public DbSet<Chateau> Chateaux { get; set; }
        public DbSet<CompetenceFamilier> CompetencesFamiliers { get; set; }
        public DbSet<Equipement> Equipements { get; set; }
        public DbSet<Familier> Familiers { get; set; }
        public DbSet<Hero> Heros { get; set; }
        public DbSet<InfosChateau> InfosChateaux { get; set; }
        public DbSet<Joyau> Joyaux { get; set; }
        public DbSet<Recherche> Recherches { get; set; }
        public DbSet<Ressource> Ressources { get; set; }
        public DbSet<StatsDuo> StatsDuos { get; set; }
        public DbSet<StatsMixte> StatsMixtes { get; set; }
        public DbSet<StatsMono> StatsMonos { get; set; }
        public DbSet<Troupes> Troupes { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
    }
}