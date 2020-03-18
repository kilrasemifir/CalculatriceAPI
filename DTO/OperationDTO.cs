using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatriceAPI.DTO
{
    public class OperationDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Valeur { get; set; }
        //public int AuteurId {get; set;}
        public UtilisateurDTO Auteur {get; set;}
    }
}
