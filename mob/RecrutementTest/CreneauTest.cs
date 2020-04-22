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
                Creneau creneau = new Creneau(new DateTime(2020,04,25),new TimeSpan(0,30,0));
                });

            Assert.Equal("Il ne peut pas y avoir d'entretien le week-end", ex.Message);
        }
    }
}
