using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatriceAPI.Models
{
    using DTO;
    public class Operation
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Valeur { get; set; }
        //public int AuteurId {get; set;}
        public Utilisateur Auteur { get; set; }

        public Operation() { }
        public Operation(int id, string nom, string valeur, Utilisateur auteur)
        {
            Id = id;
            Nom = nom;
            Valeur = valeur;
            Auteur = auteur;
        }

        public static implicit operator OperationDTO (Operation op)
        {
            return new OperationDTO(op.Id, op.Nom, op.Valeur, new UtilisateurDTO(op.Auteur));
        }
    }
}
