using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatriceAPI.Services.Impl
{


    using DTO;
    using Models;
    using Repositories;
    public class OperationStandardService : OperationService
    {
        
        private UtilisateurService utilisateurService;
        // Injection repo
        private OperationRepository repository;

        public OperationStandardService(UtilisateurService utilisateurService, OperationRepository repository){
            this.utilisateurService = utilisateurService;
            this.repository = repository;
        }

        public IEnumerable<OperationDTO> TrouverTout(){
            List<OperationDTO> result = new List<OperationDTO>();
            foreach (Operation op in this.repository.FindAll())
            {
                result.Add(op);
            }
            return result;
        }

        public OperationDTO TrouverUn(int id){
            return this.repository.FindById(id);
        }

        public OperationDTO AjouterUn(OperationDTO data){
            return this.repository.Save(data);
        }

        public OperationDTO Modifier(int id, OperationDTO data){
            return this.repository.Update(data);
        }

        public void Supprimer(int id){
            this.repository.Delete(id);
        }
    }
}