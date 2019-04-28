using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_conn
{
    interface interfaceGestionEtudiant
    {
        void ajouterEtudiant(etudiant e);
        void rechercherEtudiant(etudiant e);
       // void modifierEtudiant(etudiant e);
        void supprimerEtudiant(etudiant e);
    }
}
