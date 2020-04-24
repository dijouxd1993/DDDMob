using System;
using System.Collections.Generic;

namespace Recrutement
{

    public class Salles
    {

        private List<Salle> salles;

        public Salles()
        {
           this.salles = new List<Salle>();
        }

        public void Ajouter(Salle salle){
            salles.Add(salle);
        }

        public void Retirer(Salle salle){
            salles.Remove(salle);
        }
    }
}
