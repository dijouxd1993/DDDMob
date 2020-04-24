using System;
using System.Collections.Generic;

namespace Recrutement
{

    public class Vivier
    {

        private List<Candidat> vivier;

        public Vivier()
        {
           this.vivier = new List<Candidat>();
        }

        public void Ajouter(Candidat candidat){
            vivier.Add(candidat);
        }

        public void Retirer(Candidat candidat){
            vivier.Remove(candidat);
        }

        public List<Candidat> FiltrerParCompetences(Competence competences)
            => vivier.FindAll((c) => c.Competence.HasFlag(competences));
        
        public List<Candidat> FiltrerParNomPrenom(String nom)
            => vivier.FindAll((c) => c.Nom == nom || c.Prenom ==nom);
        


    }
}
