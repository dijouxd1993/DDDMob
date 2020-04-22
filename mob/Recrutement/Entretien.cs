using System;

namespace Recrutement
{
    public class Entretien
    {
        public Entretien(Creneau creneau, Candidat candidat, Recruteur recruteur)
        {
            this.EntretienId = new Guid();
            this.Statut = Statut.Prevu;
            this.creneau = creneau;
            this.Candidat = candidat;
            this.Recruteur = recruteur;
        }

        public int EntretienId { get; private set; }
        public Statut Statut { get; private set; }
        public Candidat Candidat { get; private set; } 
        public Recruteur Recruteur { get; private set; }

        private Creneau creneau;
    }
}
