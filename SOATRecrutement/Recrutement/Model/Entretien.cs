using System;

namespace Recrutement
{
    public class Entretien
    {
        public Entretien(Creneau creneau, Candidat candidat, Recruteur recruteur, Competence competencesTestees)
        {
            this.EntretienId = new Guid();
            this.Statut =  new Statut();
            this.Creneau = creneau;
            this.Candidat = candidat;
            this.Recruteur = recruteur;
        }

        public Guid EntretienId { get; private set; }
        public Statut Statut { get; private set; }
        public Candidat Candidat { get; private set; } 
        public Recruteur Recruteur { get; private set; }
        public Creneau Creneau { get; private set; }

        private Competence competencesTestees;
        public Competence CompetencesTestees
        {
            get { return competencesTestees; }
            set { competencesTestees = value; }
        }

        public void Confirmer() {
            this.Statut.Confirmer();
        }

        public void Annuler(string raison) {
            this.Statut.Annuler(raison);
        }
    }
}
