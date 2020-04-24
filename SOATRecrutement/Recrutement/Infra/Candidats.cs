using System;
using System.Collections.Generic;

namespace Recrutement
{

    public class Candidats : ICandidatRepsitory
    {

        private List<Candidat> vivier;

        public Candidats()
        {
           this.vivier = new List<Candidat>(){
            new Candidat("Dupont", "Jean", new DateTime(01,02,2020), (Competence)4, 2),
            new Candidat("Harly", "Pierre", new DateTime(01,02,2020), (Competence)1, 5),
            new Candidat("Maghales", "Enzo", new DateTime(04,02,2020), (Competence)7, 8),
            new Candidat("Chatelain", "Gérard",new DateTime(01,02,2020), (Competence)2, 1),
            new Candidat("Mittel", "Henri", new DateTime(01,02,2020), (Competence)1, 4)
           };
        }
        public void Retirer(Candidat candidat){
            vivier.Remove(candidat);
        }

        public List<Candidat> FiltrerParCompetences(Competence competences)
            => vivier.FindAll((c) => c.Competence.HasFlag(competences));
        
        public List<Candidat> FiltrerParNomPrenom(String nom)
            => vivier.FindAll((c) => c.Nom == nom || c.Prenom ==nom);

        public void Ajouter(Candidat candidat)
        {
            vivier.Add(candidat);
        }
    }
}
