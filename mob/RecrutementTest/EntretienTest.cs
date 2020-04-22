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
            Entretien entretien = new Entretien(new Creneau(new DateTime(2020,04,22), new TimeSpan()), new Candidat("","",DateTime.Now), new Recruteur("","",DateTime.Now));
            entretien.Annuler();
            Assert.Equal(entretien.Statut.Etat, EStatut.EnAttente);
        }

        public void LEntretienDoitEtreEnAttente()
        {
            Entretien entretien = new Entretien();
            Assert.Equal(entretien.Statut.Etat, EStatut.EnAttente);
        }
        public void LEntretienDoitEtreConfirme()
        {
            Entretien entretien = new Entretien();
            entretien.Confirmer();
            Assert.Equal(entretien.Statut.Etat, EStatut.EnAttente);
        }
    }
}
