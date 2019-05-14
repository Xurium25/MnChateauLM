using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LordMyCastle.Models
{
    public interface IDal : IDisposable
    {
        //Cette interface est utilisé pour déclarer toutes les méthodes qui devront intéragire entre le model de l'application et la base de données, et qui seront implémenter dans la Dal (Data Access Layer)

                //méthodes pour la classe Batiment
        void AjouterBatiment(int idChateau, Batiment nvBatiment);
        void ModifierNiveauBatiment(int idBatiment, int nvNiveau);
        void SupprimerBatiment(int idBatiment);

        Batiment GetBatiment(int idBatiment);
        List<Batiment> GetBatiments(int idChateau);

        List<Batiment> GetAllBatiments();

        ////méthodes pour la classe CompetenceFamilier
        //void CreerCompetenceFamilier(int idFamilier, NomCompetence nomCompetence, int niveau);
        //CompetenceFamilier GetCompetenceFamilier(int idCompetence);
        //void ModifierCompetenceFamilier(int idCompetence, int niveau);
        //void SupprimerCompetenceFamilier(int idCompetence);

                //méthodes pour la classe Chateau
        void AjouterChateau(int idUtilisateur, Chateau nvChateau);
        void ModifierNomChateau(int idChateau, string nvNom);
        void SupprimerChateau(int idChateau);
        bool ChateauExiste(string nom);

        List<Chateau> GetChateaux(int idUtilisateur);
        Chateau GetChateau(int idUtilisateur, int numChateau);
        Chateau GetChateau(int idChateau);
        Chateau GetChateau(string nom);

        List<Chateau> GetAllChateaux();

        ////méthodes pour la classe Equipement
        //void CreerEquipement(int idChateau, NomEquipement nomEquipement, string Couleur);
        //void ModifierEquipement(int idEquipement, string couleur);
        //void Supprimerequipement(int idEquipement);
        //Equipement GetEquipement(int idEquipement);
        //List<Equipement> GetEquipements(int idChateau);
        //List<Equipement> GetAllEquipements();
        //bool EquipementExiste(int idChateau, int idNomEquipement);

        ////méthodes pour la classe Familier
        //void CreerFamilier(int idChateau, NomFamilier nomFamilier, int niveau);
        //void ModifierFamilier(int idFamilier, int niveau);
        //void SupprimerFamilier(int idFamilier);
        //Familier GetFamilier(int idFamilier);
        //List<Familier> GetFamiliers(int idChateau);
        //List<Familier> GetAllFamiliers();
        //bool FamilierExiste(int idChateau, int idNomFamilier);

                //méthodes pour la classe Hero
        void AjouterHero(int idChateau, Hero nvHero );
        void ModifierHero(int idHero, Hero heroModifie);
        void SupprimerHero(int idHero);
        bool HeroExiste(int idChateau, string nomHero);

        Hero GetHero(int idHero);
        List<Hero> GetHeros(int idChateau);

        List<Hero> GetAllHerosByNom(string nomHero);
        List<Hero> GetAllHeros();

        //méthodes pour la classe InfosChateau
        void AjouterInfosChateau(int idChateau, InfosChateau nvInfos);
        void SupprimerInfosChateau(int idInfosGenerales);

        InfosChateau GetLastInfosChateau(int idChateau);
        InfosChateau GetInfosChateau(int idInfos);
        List<InfosChateau> GetAllInfosChateau(int idChateau);
        List<InfosChateau> GetAllLastInfosChateaux();

        ////méthodes pour la classe Joyau
        //void CreerJoyau(int idEquipement, NomJoyau nomJoyau, string couleur);
        //void ModifierJoyau(int idJoyau, NomJoyau nomJoyau, string couleur);
        //void SupprimerJoyau(int idJoyau);
        //Joyau GetJoyau(int idJoyau);
        //List<Joyau> GetJoyaux(int idEquipement);
        //bool VerifPossibleJoyau(int idEquipement, int idNomJoyau);

        //méthodes pour la classe Recherche
        void AjouterRecherche(int idChateau, Recherche nvRecherche);
        void ModifierNiveauRecherche(int idRecherche, int nvNiveau);
        void SupprimerRecherche(int idRecherche);
        bool RechercheExiste(int idChateau, string nomRecherche);

        Recherche GetRecherche(int idRecherche);
        List<Recherche> GetRecherchesByChateau(int idChateau);
        List<Recherche> GetAllRecherchesByNom(string nomRecherche);

        //méthodes pour la classe Ressource
        void AjouterRessource(int idChateau, Ressource nvRessource);
        void ModifierRessource(int idRessource, Ressource ressourceModifie);
        void SupprimerRessource(int idRessource);
        bool RessourceExiste(int idChateau, string nomRessource);

        Ressource GetRessource(int idRessource);
        List<Ressource> GetRessourcesByChateau(int idChateau);
        List<Ressource> GetAllRessourcesByNom(string nomRessource);

        //méthodes pour la classe StatsDuo
        void AjouterStatsDuo(int idChateau, StatsDuo nvStatsDuo);
        void ModifierStatsDuo(int idStats, StatsDuo statsDuoModifie);
        void SupprimerStatsDuo(int idStats);
        bool StatsDuoExiste(int idChateau, string nomFormation);

        StatsDuo GetStatsDuo(int idStats);
        List<StatsDuo> GetStatsDuosByChateau(int idChateau);
        List<StatsDuo> GetAllStatsDuosByNomFormation(string nomFormation);

        //méthodes pour la classe StatsStuffMixte
        void AjouterStatsMixte(int idChateau, StatsMixte nvStatsMixte);
        void ModifierStatsMixte(int idStats, StatsMixte statsMixteModifie);
        void SupprimerStatsMixte(int idStats);
        bool StatsMixteExiste(int idChateau);

        StatsMixte GetStatsMixte(int idStats);
        StatsMixte GetStatsMixteByChateau(int idChateau);
        List<StatsMixte> GetAllStatsMixtes();

        //méthodes pour la classe StatsStuffMono
        void AjouterStatsMono(int idChateau, StatsMono nvStatsMono);
        void ModifierStatsMono(int idStats, StatsMono statsMonoModifie);
        void SupprimerStatsMono(int idStats);
        bool StatsMonoExiste(int idChateau, string nomFormation);

        StatsMono GetStatsMono(int idStats);
        List<StatsMono> GetStatsMonosByChateau(int idChateau);
        List<StatsMono> GetAllStatsMonosByNomFormation(string nomFormation);

        //méthodes pour la classe Troupe
        void AjouterTroupes(int idChateau, Troupes nvTroupes);
        void SupprimerTroupes(int idTroupes);

        Troupes GetLastTroupes(int idChateau);
        Troupes GetTroupes(int idTroupes);
        List<Troupes> GetTroupesByChateau(int idChateau);
        List<Troupes> GetAllLastTroupes();

        //méthodes pour la classe Utilisateur
        int AjouterUtilisateur(Utilisateur nvUtilisateur);
        bool Authentifier(Utilisateur utilisateur);
        bool UtilisateurExiste(string nomUtilisateur);

        Utilisateur GetUtilisateur(int id);
        Utilisateur GetUtilisateur(string nomUtilisateur);
    }
}
