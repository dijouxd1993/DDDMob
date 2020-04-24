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
                new Creneau(new DateTime(2020,04,22,18,0,0), new TimeSpan(1,0,0)),
                new Candidat("","",DateTime.Now,Competence.Java,1),
                new Recruteur("","",DateTime.Now,Competence.Java,2),
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
                new Creneau(new DateTime(2020,04,22,18,0,0), new TimeSpan(1,0,0)),
                new Candidat("","",DateTime.Now,Competence.Java,1),
                new Recruteur("","",DateTime.Now,Competence.Java,2),
                Competence.Java,
                new Salle("B22")
            );
            Assert.Equal(EStatut.EnAttente, entretien.Statut.Etat);
        }

        [Fact]
        public void LEntretienDoitEtreConfirme()
        {
            Entretien entretien = new Entretien(
                new Creneau(new DateTime(2020,04,22,18,0,0), new TimeSpan(1,0,0)),
                new Candidat("","",DateTime.Now,Competence.Java,1),
                new Recruteur("","",DateTime.Now,Competence.Java,2),
                Competence.Java,
                new Salle("B22")
            );
            entretien.Confirmer();
            Assert.Equal(EStatut.Confirme, entretien.Statut.Etat);
        }

        [Fact]
		public void LeRecruteurDoitEtrePlusExperimente()
		{
			Recruteur recruteur = new Recruteur("", "", DateTime.Now, Competence.JavaScript, 5);
			Candidat candidat = new Candidat("", "", DateTime.Now, Competence.JavaScript, 10);
            Exception ex = Assert.Throws<Exception>(() => {
                new Entretien(new Creneau(new DateTime(2020,04,22,18,0,0), new TimeSpan(1,0,0)), candidat, recruteur, Competence.JavaScript, new Salle(""));
            });
            Assert.Equal("Le recruteur doit être plus expérimenté", ex.Message);
		}

		[Fact]
		public void LeCandidatDoitAvoirLaCompetenceTestee()
		{
			Recruteur recruteur = new Recruteur("", "", DateTime.Now, Competence.JavaScript, 10);
			Candidat candidat = new Candidat("", "", DateTime.Now, Competence.Java, 5);
            Exception ex = Assert.Throws<Exception>(() => {
                new Entretien(new Creneau(new DateTime(2020,04,22,18,0,0), new TimeSpan(1,0,0)), candidat, recruteur, Competence.JavaScript, new Salle(""));
            });
            Assert.Equal("Le candidat doit avoir la compétence testée.", ex.Message);
		}

		[Fact]
		public void LeRecruteurDoitAvoirLaCompetenceTestee()
		{
			Recruteur recruteur = new Recruteur("", "", DateTime.Now, Competence.Java, 5);
			Candidat candidat = new Candidat("", "", DateTime.Now, Competence.JavaScript, 1);
			Exception ex = Assert.Throws<Exception>(() => {
                new Entretien(new Creneau(new DateTime(2020,04,22,18,0,0), new TimeSpan(1,0,0)), candidat, recruteur, Competence.JavaScript, new Salle(""));
            });
            Assert.Equal("Le recruteur doit avoir la compétence testée.", ex.Message);
		}
    }
}
