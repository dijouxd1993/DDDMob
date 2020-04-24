using System;

namespace Recrutement
{
    public class PlanificateurDEntretien
    {
        private Candidat candidat;
        public Candidat Candidat
        {
            get { return candidat; }
            private set 
            { 

                if(value is null)
                    throw new Exception("Il faut un candidat");

                candidat = value;
            }
        }

        private Recruteur recruteur;
        public Recruteur Recruteur
        {
            get { return recruteur; }
            set { 

                if(value is null)
                    throw new Exception("Il faut un candidat");
                
                recruteur = value; 
            }
        }
        
        private Salle salle;
        public Salle Salle
        {
            get { return salle; }
            set { salle = value; }
        }

        private Creneau creneau;
        public Creneau Creneau
        {
            get { return creneau; }
            set { creneau = value; }
        }

        private Competence competenceTestee;
        public Competence CompetenceTestee
        {
            get { return competenceTestee; }
            set { 
                competenceTestee = value;
            }
        }
        
        public PlanificateurDEntretien(Recruteur recruteur, Candidat candidat, Salle salle, Creneau creneau, Competence competenceTestee){
            this.CompetenceTestee = competenceTestee;
            this.Recruteur = recruteur;
            this.Candidat = candidat;
            this.Salle = salle;
            this.Creneau = Creneau;
        }

        public Entretien planifier()
        {
            if(Candidat?.NbAnneesExp >= Recruteur?.NbAnneesExp)
                throw new Exception("Le recruteur doit être plus expérimenté");
            
            if (Candidat.Competence.HasFlag(competenceTestee))
                throw new Exception("Le candidat doit avoir la compétence testée.");
            
            if (Recruteur.Competence.HasFlag(competenceTestee))
                throw new Exception("Le recruteur doit avoir la compétence testée.");
            
            return new Entretien(creneau, candidat, recruteur, competenceTestee, salle);
        }
    }
}