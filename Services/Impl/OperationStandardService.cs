using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatriceAPI.Services.Impl
{
    using DTO;
    public class OperationStandardService : OperationService
    {
        private static List<OperationDTO> operations = new List<OperationDTO>();
        private UtilisateurService utilisateurService;

        public OperationStandardService(UtilisateurService utilisateurService){
            this.utilisateurService = utilisateurService;
        }
        public IEnumerable<OperationDTO> TrouverTout(){
            return operations.Where(u => u != null);
        }
        public OperationDTO TrouverUn(int id){
            return operations[id];
        }
        public OperationDTO AjouterUn(OperationDTO data){
            data.Id = operations.Count();
            data.Auteur = this.utilisateurService.TrouverUnUtilisateur(data.AuteurId);
            operations.Add(data);
            return data;
        }
        public OperationDTO Modifier(int id, OperationDTO data){
            data.Id = id;
            operations[id] = data;
            return data;
        }
        public void Supprimer(int id){
            operations[id] = null;
        }
    }
}