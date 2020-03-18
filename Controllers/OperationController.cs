using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatriceAPI.Controllers
{
    using DTO;
    using Services;
    using Services.Impl;

    [Route("api/operations")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        // Je creer un attribut pour mon service
        private OperationService service;

        public OperationController(OperationService service){
            this.service = service;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<OperationDTO> FindAll()
        {
            return this.service.TrouverTout();
        }

        [HttpPost]
        [Route("")]
        public OperationDTO Save([FromBody] OperationDTO data)
        {
            return this.service.AjouterUn(data);
        }

        [HttpGet]
        [Route("{id}")]
        public OperationDTO FindById(int id)
        {
            return this.service.TrouverUn(id);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            this.service.Supprimer(id);
        }

        [HttpPut]
        [Route("{id}")]
        public OperationDTO Update(int id, [FromBody] OperationDTO data)
        {
            return this.service.Modifier(id, data);
        }
    }
}