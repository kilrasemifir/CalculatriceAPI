using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatriceAPI.Services
{
    using DTO;
    public interface UtilisateurService
    {
        public IEnumerable<UtilisateurDTO> TrouverTout();
        public UtilisateurDTO TrouverUnUtilisateur(int id);
        public UtilisateurDTO AjouterUnUtilisateur(UtilisateurDTO utilisateur);
        public void SupprimerUtilisateur(int id);
        public UtilisateurDTO Modifier(int id, UtilisateurDTO nouveau);
        public IEnumerable<UtilisateurDTO> TrouverParNom(string nom);
        public IEnumerable<UtilisateurDTO> TrouverParAge(int age);
        public IEnumerable<UtilisateurDTO> TrouverParAge(int min, int max);
        public IEnumerable<UtilisateurDTO> TrouverParMetier(string metier);
    }
}