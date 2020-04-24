using System;

namespace Recrutement
{
    public class SalleDTO
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public SalleDTO(string nom)
        {
            this.Nom = nom;
        }
    }
}