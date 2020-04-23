using System;

namespace Recrutement
{
    public class Creneau
    {
        public Creneau(DateTime debut, TimeSpan duree)
        {
            this.Debut = debut;
            this.Fin = debut.Add(duree);
        }

        private DateTime debut;
        public DateTime Debut
        {
            get { return debut; }
            private set {
                if (EstUnJourDeWeekEnd(value))
                    throw new Exception("Il ne peut pas y avoir d'entretien le week-end");
                debut = value;
            }
        }
        
        private bool EstUnJourDeWeekEnd(DateTime date) {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) {
                return true;
            }

            return false;
        }

        public DateTime Fin {get; private set;}

        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
			Creneau creneau = obj as Creneau;

			if (creneau?.Debut != this.Debut)
			{
				return false;
			}

			if (creneau?.Fin != this.Fin)
			{
				return false;
			}
            return true;
        }
    }
}
