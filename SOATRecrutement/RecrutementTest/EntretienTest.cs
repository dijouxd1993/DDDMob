using System;
using Xunit;
using Recrutement;
namespace RecrutementTest
{
    public class EntretienTest
    {
        

        [Fact]
        public void LEntretienDoitEtreAnnule()
        {
            Entretien entretien = new Entretien(
                new Creneau(new DateTime(2020,04,22), new TimeSpan()),
                new Candidat("","",DateTime.Now,Competence.Java,1),
                new Recruteur("","",DateTime.Now,Competence.Java,1),
                Competence.Java,
                new Salle("B22")
            );
            entretien.Annuler("Ceci est une raison");
            Assert.Equal(EStatut.Annule, entretien.Statut.Etat);
        }

        [Fact]
        public void LEntretienDoitEtreEnAttente()
        {
            Entretien entretien = new Entretien(
                new Creneau(new DateTime(2020,04,22), new TimeSpan()),
                new Candidat("","",DateTime.Now,Competence.Java,1),
                new Recruteur("","",DateTime.Now,Competence.Java,1),
                Competence.Java,
                new Salle("B22")
            );
            Assert.Equal(EStatut.EnAttente, entretien.Statut.Etat);
        }

        [Fact]
        public void LEntretienDoitEtreConfirme()
        {
            Entretien entretien = new Entretien(
                new Creneau(new DateTime(2020,04,22), new TimeSpan()),
                new Candidat("","",DateTime.Now,Competence.Java,1),
                new Recruteur("","",DateTime.Now,Competence.Java,1),
                Competence.Java,
                new Salle("B22")
            );
            entretien.Confirmer();
            Assert.Equal(EStatut.Confirme, entretien.Statut.Etat);
        }
    }
}
