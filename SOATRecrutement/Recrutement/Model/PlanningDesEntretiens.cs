using System;
using System.Collections.Generic;

namespace Recrutement
{

    public class PlanningDesEntretiens
    {

        private List<Entretien> planning;

        public PlanningDesEntretiens()
        {
           this.planning = new List<Entretien>();
        }

        public void Planifier(Entretien entretien){
            if(FiltrerParCreneau(entretien.Creneau).Count > 0 && FiltrerParSalle(entretien.Salle).Count > 0 )
                throw new Exception("Le planning est déjà complet à ce creneau pour ce recruteur");
            planning.Add(entretien);
        }

        public void Retirer(Entretien entretien){
            planning.Remove(entretien);
        }

        public void Annuler(Entretien entretien, String raison){
            planning.Find((e) =>  e == entretien)?.Annuler(raison);
        }

        public List<Entretien> FiltrerParCreneau(Creneau creneau)
            => planning.FindAll((p) => p.Creneau == creneau);

        public List<Entretien> FiltrerParSalle(Salle salle)
            => planning.FindAll((p) => p.Salle == salle);
        
        public List<Entretien> FiltrerParDate(DateTime date)
            => planning.FindAll((p) => p.Creneau.Debut.Date == date);
        


    }
}
