using System;

namespace Recrutement
{
    public class Creneau
    {
        public Creneau(DateTime debut, TimeSpan duree)
        {
            this.Debut = debut;
            this.Fin = debut.Add(duree);
            if (duree.Hours < 1 || duree.Hours > 3)
                throw new Exception("La durée d'un créneau doit être d'une, deux ou trois heures.");
        }

        private DateTime debut;
        public DateTime Debut
        {
            get { return debut; }
            private set {
                if (EstUnJourDeWeekEnd(value))
                    throw new Exception("Il ne peut pas y avoir d'entretien le week-end");
                if (value.Hour < 18)
                    throw new Exception("Un créneau doit commencer au moins à 18h.");
                debut = value;
            }
        }
        
        private bool EstUnJourDeWeekEnd(DateTime date) {
            return (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);
        }

        public DateTime Fin { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
			Creneau creneau = obj as Creneau;

			return (creneau?.Debut == this.Debut && creneau?.Fin == this.Fin);
        }
    }
}
