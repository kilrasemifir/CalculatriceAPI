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
        public IEnumerable<OperationDTO> TrouverTout(){
            return operations.Where(u => u != null);
        }
        public OperationDTO TrouverUn(int id){
            return operations[id];
        }
        public OperationDTO AjouterUn(OperationDTO user){
            user.Id = operations.Count();
            operations.Add(user);
            return user;
        }
        public OperationDTO Modifier(int id, OperationDTO user){
            user.Id = id;
            operations[id] = user;
            return user;
        }
        public void Supprimer(int id){
            operations[id] = null;
        }
    }
}