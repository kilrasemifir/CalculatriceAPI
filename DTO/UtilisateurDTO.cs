using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatriceAPI.DTO
{
    using Models;
    public class UtilisateurDTO : Utilisateur
    {
        public UtilisateurDTO(int id, string nom, string prenom, int age, string metier)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Metier = metier;
        }
        
        public UtilisateurDTO(Utilisateur us)
        {
            this.Id = us.Id;
            this.Nom = us.Nom;
            Prenom = us.Prenom;
            Age = us.Age;
            Metier = us.Metier;
        }
    }
}
