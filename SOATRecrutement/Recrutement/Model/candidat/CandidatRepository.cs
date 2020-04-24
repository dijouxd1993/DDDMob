using System;
using System.Collections.Generic;

namespace Recrutement
{
    public interface ICandidatRepsitory
    {

        void Ajouter(Candidat candidat);

        void Retirer(Candidat candidat);

        List<Candidat> FiltrerParCompetences(Competence competences);
        
        List<Candidat> FiltrerParNomPrenom(String nom);

    }
}
