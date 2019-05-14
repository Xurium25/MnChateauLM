using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace LordMyCastle.Models
{
    public class Dal : IDal
    {
        //Data Acces Layer, implémente toutes les fonctions d'accès à la base de donnée
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        //Fonction qui permet d'encoder le mot de passe et de le sauvegarder dans la base de donnée dans une forme crypté
        public string EncodeMD5(string password)
        {
            string motDePasseSel = "LM_fif" + password + "ASP.NET MVC";
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(motDePasseSel)));
        }

        //-----------------méthodes pour la classe Batiment---------------------------------

        public void AjouterBatiment(int idChateau, Batiment nvBatiment)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.Batiments == null)
                chateau.Batiments = new List<Batiment>();

            chateau.Batiments.Add(nvBatiment);
            bdd.SaveChanges();
        }

        public void ModifierNiveauBatiment(int idBatiment, int nvNiveau)
        {
            Batiment batiment = GetBatiment(idBatiment);
            batiment.Niveau = nvNiveau;
            bdd.SaveChanges();
        }

        public void SupprimerBatiment(int idBatiment)
        {
            Batiment batiment = GetBatiment(idBatiment);
            bdd.Batiments.Remove(batiment);
            bdd.SaveChanges();
        }

        public Batiment GetBatiment(int idBatiment)
        { return bdd.Batiments.FirstOrDefault(c => c.Id == idBatiment); }

        public List<Batiment> GetBatiments(int idChateau)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.Batiments != null)
                return chateau.Batiments;
            else
                return new List<Batiment>();
        }

        public List<Batiment> GetAllBatiments()
        { return bdd.Batiments.ToList(); }


        //-------------------méthodes pour la classe Chateau-----------------

        public void AjouterChateau(int idUtilisateur, Chateau nvChateau)
        {
            Utilisateur utilisateur = GetUtilisateur(idUtilisateur);
            //La condition suivante est indispensable car si l'utilasteur ne contient pas de chateau la proprièté utilisateur.Chateaux vaut null et on ne peut pas faire un add sur quelques choses de null
            if (utilisateur.Chateaux == null)
                utilisateur.Chateaux = new List<Chateau>(); //si la proprièté est null on lui attribut une liste de chateau vide qui ne sera donc pas une référence null lors de l'appelle de la fonction add dans la condition suivante

            utilisateur.Chateaux.Add(new Chateau { Nom = nvChateau.Nom });
            bdd.SaveChanges();

        }

        public void ModifierNomChateau(int idChateau, string nvNom)
        {
            Chateau chateau = GetChateau(idChateau);
            chateau.Nom = nvNom;
            bdd.SaveChanges();
        }

        public void SupprimerChateau(int idChateau)
        {
            Chateau chateau = GetChateau(idChateau);
            bdd.Chateaux.Remove(chateau);
            bdd.SaveChanges();
        }

        public bool ChateauExiste(string nom)
        { return bdd.Chateaux.Any(chateau => string.Compare(chateau.Nom, nom, StringComparison.CurrentCulture) == 0); }

        public List<Chateau> GetChateaux(int idUtilisateur)
        {
            Utilisateur utilisateur = GetUtilisateur(idUtilisateur);
            if (utilisateur.Chateaux != null)
                return utilisateur.Chateaux;
            else
                return new List<Chateau>();
        }

        public Chateau GetChateau(int idUtilisateur, int numChateau)
        {
            Utilisateur utilisateur = GetUtilisateur(idUtilisateur);
            return utilisateur.Chateaux[numChateau];
        }

        public Chateau GetChateau(int idChateau)
        { return bdd.Chateaux.FirstOrDefault(c => c.Id == idChateau); }

        public Chateau GetChateau(string nom)
        { return bdd.Chateaux.FirstOrDefault(c => c.Nom == nom); }

        public List<Chateau> GetAllChateaux()
        { return bdd.Chateaux.ToList(); }


        //--------------méthodes pour la classe Hero--------------
        public void AjouterHero(int idChateau, Hero nvHero)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.Heros == null)
                chateau.Heros = new List<Hero>();

            chateau.Heros.Add(nvHero);
            bdd.SaveChanges();
        }

        public void ModifierHero(int idHero, Hero heroModifie)
        {
            Hero hero = GetHero(idHero);
            heroModifie.Id = idHero; //on s'assure que les modifications se passe sur la même ligne de la table
            hero = heroModifie;
            bdd.SaveChanges();
        }

        public void SupprimerHero(int idHero)
        {
            Hero hero = GetHero(idHero);
            bdd.Heros.Remove(hero);
            bdd.SaveChanges();
        }

        public bool HeroExiste(int idChateau, string nomHero)
        {
            Chateau chateau = GetChateau(idChateau);
            return chateau.Heros.Any(hero => string.Compare(hero.Nom, nomHero, StringComparison.CurrentCulture) == 0);
        }

        public Hero GetHero(int idHero)
        { return bdd.Heros.FirstOrDefault(h => h.Id == idHero); }

        public List<Hero> GetHeros(int idChateau)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.Heros != null)
                return chateau.Heros;
            else
                return new List<Hero>();
        }

        public List<Hero> GetAllHerosByNom(string nomHero)
        {
            return bdd.Heros.Where(h => h.Nom == nomHero).ToList();
        }

        public List<Hero> GetAllHeros()
        { return bdd.Heros.ToList(); }

        //----------méthodes pour la classe InfosChateau--------------
        public void AjouterInfosChateau(int idChateau, InfosChateau nvInfos)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.InfosChateau == null)
                chateau.InfosChateau = new List<InfosChateau>();
            chateau.InfosChateau.Add(nvInfos);
            bdd.SaveChanges();
        }

        public void SupprimerInfosChateau(int idInfosGenerales)
        {
            InfosChateau infos = GetInfosChateau(idInfosGenerales);
            bdd.InfosChateaux.Remove(infos);
            bdd.SaveChanges();
        }

        public InfosChateau GetLastInfosChateau(int idChateau)
        {
            Chateau chateau = GetChateau(idChateau);

            if (chateau.InfosChateau == null)
                return new InfosChateau();
 
            return chateau.InfosChateau[chateau.InfosChateau.Count - 1];
        }

        public InfosChateau GetInfosChateau(int idInfos)
        { return bdd.InfosChateaux.LastOrDefault(i => i.Id == idInfos); }

        public List<InfosChateau> GetAllInfosChateau(int idChateau)
        { return bdd.InfosChateaux.ToList(); }

        public List<InfosChateau> GetAllLastInfosChateaux()
        {
            List<InfosChateau> listeInfos = new List<InfosChateau>();
            List<Chateau> listeChateaux = GetAllChateaux();
            foreach (Chateau chateau in listeChateaux)
            {
                if (chateau.InfosChateau != null)
                    listeInfos.Add(chateau.InfosChateau[chateau.InfosChateau.Count - 1]);
            }
            return listeInfos;
        }

        //méthodes pour la classe Recherche
        public void AjouterRecherche(int idChateau, Recherche nvRecherche)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.Recherches == null)
                chateau.Recherches = new List<Recherche>();

            chateau.Recherches.Add(nvRecherche);
            bdd.SaveChanges();
        }

        public void ModifierNiveauRecherche(int idRecherche, int nvNiveau)
        {
            Recherche recherche = GetRecherche(idRecherche);
            recherche.Niveau = nvNiveau;
            bdd.SaveChanges();
        }

        public void SupprimerRecherche(int idRecherche)
        {
            Recherche recherche = GetRecherche(idRecherche);
            bdd.Recherches.Remove(recherche);
            bdd.SaveChanges();
        }

        public bool RechercheExiste(int idChateau, string nomRecherche)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.Recherches != null)            
                return chateau.Recherches.Exists(r => r.Nom == nomRecherche);
            else
                return false;
        }

        public Recherche GetRecherche(int idRecherche)
        { return bdd.Recherches.FirstOrDefault(r => r.Id == idRecherche); }

        public List<Recherche> GetRecherchesByChateau(int idChateau)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.Recherches == null)
                chateau.Recherches = new List<Recherche>();
            return chateau.Recherches;
        }

        public List<Recherche> GetAllRecherchesByNom(string nomRecherche)
        { return bdd.Recherches.ToList().Where(r => r.Nom == nomRecherche).ToList(); }

        //méthodes pour la classe Ressource
        public void AjouterRessource(int idChateau, Ressource nvRessource)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.Ressources == null)
                chateau.Ressources = new List<Ressource>();
            chateau.Ressources.Add(nvRessource);
            bdd.SaveChanges();
        }

        public void ModifierRessource(int idRessource, Ressource ressourceModifie)
        {
            Ressource ressource = GetRessource(idRessource);
            ressourceModifie.Id = idRessource;
            ressource = ressourceModifie;
            bdd.SaveChanges();
        }

        public void SupprimerRessource(int idRessource)
        {
            Ressource ressource = GetRessource(idRessource);
            bdd.Ressources.Remove(ressource);
            bdd.SaveChanges();
        }

        public bool RessourceExiste(int idChateau, string nomRessource)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.Ressources != null)
                return chateau.Ressources.Exists(r => r.Nom == nomRessource);
            else
                return false;
        }

        public Ressource GetRessource(int idRessource)
        { return bdd.Ressources.FirstOrDefault(r => r.Id == idRessource); }

        public List<Ressource> GetRessourcesByChateau(int idChateau)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.Ressources == null)
                chateau.Ressources = new List<Ressource>();
            return chateau.Ressources;
        }

        public List<Ressource> GetAllRessourcesByNom(string nomRessource)
        { return bdd.Ressources.ToList().Where(r => r.Nom == nomRessource).ToList(); }

        //méthodes pour la classe StatsDuo
        public void AjouterStatsDuo(int idChateau, StatsDuo nvStatsDuo)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.StatsDuos == null)
                chateau.StatsDuos = new List<StatsDuo>();
            chateau.StatsDuos.Add(nvStatsDuo);
            bdd.SaveChanges();
        }

        public void ModifierStatsDuo(int idStats, StatsDuo statsDuoModifie)
        {
            StatsDuo statsDuo = GetStatsDuo(idStats);
            statsDuoModifie.Id = idStats;
            statsDuo = statsDuoModifie;
            bdd.SaveChanges();
        }

        public void SupprimerStatsDuo(int idStats)
        {
            StatsDuo statsDuo = GetStatsDuo(idStats);
            bdd.StatsDuos.Remove(statsDuo);
            bdd.SaveChanges();
        }

        public bool StatsDuoExiste(int idChateau, string nomFormation)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.StatsDuos != null)
                return chateau.StatsDuos.Exists(r => r.NomFormation == nomFormation);
            else
                return false;
        }

        public StatsDuo GetStatsDuo(int idStats)
        { return bdd.StatsDuos.FirstOrDefault(r => r.Id == idStats); }

        public List<StatsDuo> GetStatsDuosByChateau(int idChateau)
        {
            Chateau chateau = GetChateau(idChateau);
            if (chateau.StatsDuos == null)
                chateau.StatsDuos = new List<StatsDuo>();
            return chateau.StatsDuos;
        }

        public List<StatsDuo> GetAllStatsDuosByNomFormation(string nomFormation) { }

        //méthodes pour la classe StatsStuffMixte
        public void AjouterStatsMixte(int idChateau, StatsMixte nvStatsMixte) { }
        public void ModifierStatsMixte(int idStats, StatsMixte statsMixteModifie) { }
        public void SupprimerStatsMixte(int idStats) { }
        public bool StatsMixteExiste(int idChateau) { }

        public StatsMixte GetStatsMixte(int idStats) { }
        public StatsMixte GetStatsMixteByChateau(int idChateau) { }
        public List<StatsMixte> GetAllStatsMixtes() { }

        //méthodes pour la classe StatsStuffMono
        public void AjouterStatsMono(int idChateau, StatsMono nvStatsMono) { }
        public void ModifierStatsMono(int idStats, StatsMono statsMonoModifie) { }
        public void SupprimerStatsMono(int idStats) { }
        public bool StatsMonoExiste(int idChateau, string nomFormation) { }

        public StatsMono GetStatsMono(int idStats) { }
        public List<StatsMono> GetStatsMonosByChateau(int idChateau) { }
        public List<StatsMono> GetAllStatsMonosByNomFormation(string nomFormation) { }

        //méthodes pour la classe Troupe
        public void AjouterTroupes(int idChateau, Troupes nvTroupes) { }
        public void SupprimerTroupes(int idTroupes) { }

        public Troupes GetLastTroupes(int idChateau) { }
        public Troupes GetTroupes(int idTroupes) { }
        public List<Troupes> GetTroupesByChateau(int idChateau) { }
        public List<Troupes> GetAllLastTroupes() { }

        //méthodes pour la classe Utilisateur
        public int AjouterUtilisateur(Utilisateur nvUtilisateur)
        {
            if (!UtilisateurExiste(nvUtilisateur.Pseudo))
            {
                string passwordEncode = EncodeMD5(nvUtilisateur.Password);
                Utilisateur utilisateur = new Utilisateur { Pseudo = nvUtilisateur.Pseudo, Password = passwordEncode };
                bdd.Utilisateurs.Add(utilisateur);
                bdd.SaveChanges();
                return utilisateur.Id;
            }
            else return 0;
        }
        public bool Authentifier(Utilisateur utilisateur)
        {
            string passwordEncode = EncodeMD5(utilisateur.Password);
            return bdd.Utilisateurs.Any(u => u.Pseudo == utilisateur.Pseudo && u.Password == passwordEncode);
        }
        public bool UtilisateurExiste(string nomUtilisateur)
        { return bdd.Utilisateurs.Any(utilisateur => string.Compare(utilisateur.Pseudo, nomUtilisateur, StringComparison.CurrentCulture) == 0); }

        public Utilisateur GetUtilisateur(int id)
        { return bdd.Utilisateurs.FirstOrDefault(u => u.Id == id); }
        public Utilisateur GetUtilisateur(string nomUtilisateur)
        { return bdd.Utilisateurs.FirstOrDefault(u => u.Pseudo == nomUtilisateur); }
    }
}