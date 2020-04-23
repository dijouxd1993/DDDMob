using System;

namespace Recrutement
{
    public class Statut
    {
        public Statut()
        {
            this.Raison= String.Empty;
            this.Etat = EStatut.EnAttente;
        }

        public EStatut Etat { get; private set; }
        public string Raison { get; private set; } 

        public void Annuler(string raison){
            this.Etat = EStatut.Annule;
            this.Raison= raison;
        }

        public void Confirmer(){
            this.Etat = EStatut.Confirme;
            this.Raison= String.Empty;
        }
        
    }  

    public enum EStatut {
        EnAttente,
        Annule,
        Confirme
    }

}   
