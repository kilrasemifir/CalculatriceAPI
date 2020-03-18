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

    [Route("api/utilisateurs")]
    [ApiController]
    public class UtilisationController : ControllerBase
    {
        private static UtilisateurService service = new UtilisateurCalculatriceService();

        [HttpGet]
        public IEnumerable<UtilisateurDTO> FindAll()
        {
            return service.TrouverTout();
        }

        [HttpPost]
        public UtilisateurDTO Save([FromBody] UtilisateurDTO value)
        {
            return service.AjouterUnUtilisateur(value);
        }

        [HttpGet]
        [Route("{id}")]
        public UtilisateurDTO FindById(int id)
        {
            return service.TrouverUnUtilisateur(id);
        }

        [HttpPut("{id}")]
        public UtilisateurDTO Update(int id, [FromBody] UtilisateurDTO value)
        {
            return service.Modifier(id, value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.SupprimerUtilisateur(id);
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public IEnumerable<UtilisateurDTO> FindByNom(string nom)
        {
            return service.TrouverParNom(nom);
        }

        [HttpGet]
        [Route("age/{age}")]
        public IEnumerable<UtilisateurDTO> FindByAge(int age)
        {
            return service.TrouverParAge(age);
        }

        [HttpGet]
        [Route("age")]
        public IEnumerable<UtilisateurDTO> FindByAge(int min, int max = 1_000)
        {
            return service.TrouverParAge(min,max);
        }

        [HttpGet]
        [Route("metier/{metier}")]
        public IEnumerable<UtilisateurDTO> FindByMetier(string metier)
        {
            return service.TrouverParMetier(metier);
        }
    }
}
