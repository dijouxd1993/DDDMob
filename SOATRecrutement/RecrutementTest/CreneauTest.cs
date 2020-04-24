using System;
using Xunit;
using Recrutement;

namespace RecrutementTest
{
    public class CreneauTest
    {
        [Fact]
        public void LeCreneauNeDoitPasEtreUnJourDeWeekEnd()
        {
            
            Exception ex = Assert.Throws<Exception>(() => {
                Creneau creneau = new Creneau(new DateTime(2020,04,25,18,0,0),new TimeSpan(1,0,0));
            });

            Assert.Equal("Il ne peut pas y avoir d'entretien le week-end", ex.Message);
        }

        [Fact]
        public void LeCreneauDoitEtreUnJourDeSemaine()
        {
            Creneau creneau = new Creneau(new DateTime(2020,04,22,18,0,0),new TimeSpan(1,0,0)); 
            Assert.Equal(creneau.Debut, new DateTime(2020,04,22,18,0,0));
        }

        [Fact]
        public void LeCreneauNeDoitPasCommencerAvant18h()
        {
            
            Exception ex = Assert.Throws<Exception>(() => {
                Creneau creneau = new Creneau(new DateTime(2020,04,24,17,0,0),new TimeSpan(1,0,0));
            });
            Assert.Equal("Un créneau doit commencer au moins à 18h.", ex.Message);
        }

        [Fact]
        public void LeCreneauDoitPasCommencerApres18h()
        {
            Creneau creneau = new Creneau(new DateTime(2020,04,24,19,0,0),new TimeSpan(1,0,0));
            Assert.Equal(creneau.Debut, new DateTime(2020,04,24,19,0,0));
        }

        [Fact]
        public void LeCreneauNeDoitPasDuree4h()
        {
            
            Exception ex = Assert.Throws<Exception>(() => {
                Creneau creneau = new Creneau(new DateTime(2020,04,24,18,0,0),new TimeSpan(4,0,0));
            });
            Assert.Equal("La durée d'un créneau doit être d'une, deux ou trois heures.", ex.Message);
        }

        [Fact]
        public void LeCreneauDoitPouvoirDurer2h()
        {
            Creneau creneau = new Creneau(new DateTime(2020,04,24,19,0,0), new TimeSpan(2,0,0));
            Assert.Equal(creneau.Debut, new DateTime(2020,04,24,19,0,0));
        }

    }
}
