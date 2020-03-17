using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatriceAPI.Controllers
{
    using DTO;

    [Route("api/utilisateurs")]
    [ApiController]
    public class UtilisationController : ControllerBase
    {
        private static List<UtilisateurDTO> utilisateurs = new List<UtilisateurDTO>();

        [HttpGet]
        public IEnumerable<UtilisateurDTO> FindAll()
        {
            return utilisateurs;
        }

        [HttpPost]
        public void Save([FromBody] UtilisateurDTO value)
        {
            utilisateurs.Add(value);
        }

        [HttpGet]
        [Route("{id}")]
        public UtilisateurDTO FindById(int id)
        {
            return utilisateurs[id];
        }

        [HttpPut("{id}")]
        public UtilisateurDTO Update(int id, [FromBody] UtilisateurDTO value)
        {
            value.Id = id;
            utilisateurs[id] = value;
            return value;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            utilisateurs[id] = null;
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public IEnumerable<UtilisateurDTO> FindByNom(string nom)
        {
            return utilisateurs.Where(op => op.Nom == nom);
        }

        [HttpGet]
        [Route("prenom/{prenom}")]
        public IEnumerable<UtilisateurDTO> FindByPrenom(string prenom)
        {
            return utilisateurs.Where(op => op.Prenom == prenom);
        }

        [HttpGet]
        [Route("age/{age}")]
        public IEnumerable<UtilisateurDTO> FindByPrenom(int age)
        {
            return utilisateurs.Where(op => op.Age == age);
        }

        [HttpGet]
        [Route("metier/{metier}")]
        public IEnumerable<UtilisateurDTO> FindByMetier(string metier)
        {
            return utilisateurs.Where(op => op.Metier == metier);
        }
    }
}
