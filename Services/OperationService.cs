using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatriceAPI.Services
{
    using DTO;
    public interface OperationService
    {
        public IEnumerable<OperationDTO> TrouverTout();
        public OperationDTO TrouverUn(int id);
        public OperationDTO AjouterUn(OperationDTO utilisateur);
        public void Supprimer(int id);
        public OperationDTO Modifier(int id, OperationDTO nouveau);
    }
}