using System;
using Xunit;
using Recrutement;

namespace RecrutementTest
{
	public class PlanificateurTest
	{
		/*public PlanificateurDEntretien planificateur;

		public PlanificateurTest() {
			Recruteur recruteur = new Recruteur("", "", DateTime.Now, Competence.JavaScript, 5);
			Candidat candidat = new Candidat("", "", DateTime.Now, Competence.JavaScript, 10);
			PlanificateurDEntretien planif = new PlanificateurDEntretien(recruteur, candidat, new Salle(), null, Competence.JavaScript);
		}*/


		/*[Fact]
		public void LeRecruteurDoitEtrePlusExperimente()
		{
			Recruteur recruteur = new Recruteur("", "", DateTime.Now, Competence.JavaScript, 5);
			Candidat candidat = new Candidat("", "", DateTime.Now, Competence.JavaScript, 10);
			PlanificateurDEntretien planif = new PlanificateurDEntretien(recruteur, candidat, new Salle(""), null, Competence.JavaScript);

			Exception ex = Assert.Throws<Exception>(() => {
                planif.planifier();
            });

            Assert.Equal("Le recruteur doit être plus expérimenté", ex.Message);
		}

		[Fact]
		public void LeCandidatDoitAvoirLaCompetenceTestee()
		{
			Recruteur recruteur = new Recruteur("", "", DateTime.Now, Competence.JavaScript, 5);
			Candidat candidat = new Candidat("", "", DateTime.Now, Competence.Java, 10);
			PlanificateurDEntretien planif = new PlanificateurDEntretien(recruteur, candidat, new Salle(""), null, Competence.JavaScript);

			Exception ex = Assert.Throws<Exception>(() => {
                planif.planifier();
            });

            Assert.Equal("Le candidat doit avoir la compétence testée.", ex.Message);
		}

		[Fact]
		public void LeRecruteurDoitAvoirLaCompetenceTestee()
		{
			Recruteur recruteur = new Recruteur("", "", DateTime.Now, Competence.Java, 5);
			Candidat candidat = new Candidat("", "", DateTime.Now, Competence.JavaScript, 10);
			PlanificateurDEntretien planif = new PlanificateurDEntretien(recruteur, candidat, new Salle(""), null, Competence.JavaScript);

			Exception ex = Assert.Throws<Exception>(() => {
                planif.planifier();
            });

            Assert.Equal("Le recruteur doit avoir la compétence testée.", ex.Message);
		}*/
	}
}