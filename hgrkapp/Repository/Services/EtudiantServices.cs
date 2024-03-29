﻿using Flurl;
using Flurl.Http;
using hgrkapp.DTO;
using hgrkapp.Repository.IServices;
using hgrkapp.Routes;

namespace hgrkapp.Repository.Services
{
    public class EtudiantServices : IEtudiantServices
    {
        public async Task<etudiant> CreateEtudiantAsync(etudiant etudiants)
        {
            try
            {

                var response = await routes_const.CreateStudent
                     .PostJsonAsync(etudiants)
                     .ReceiveJson<etudiant>();
                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Handle the exception or log it
                Console.WriteLine($"Error during POST request: {ex.Message}");
                throw;
            }
        }

        public async Task<List<etudiant>> GetEtudiantAsync()
        {
            try
            {
                var response = await routes_const.GetStudent
                     .GetJsonAsync<List<etudiant>>();
                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Gérer l'exception ou la journaliser
                Console.WriteLine($"Erreur lors de la requête GET: {ex.Message}");
                throw;
            }
            throw new NotImplementedException();
        }

        public async Task<string> SaveListOffStudent(List<etudiant> etudiants)
        {
            try
            {

                var response = await routes_const.SaveListOfStudent
                     .PostJsonAsync(etudiants)
                     .ReceiveJson<string>();
                    
                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Handle the exception or log it
                Console.WriteLine($"Error during POST request: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<EtudiantMixedDto>> SearchStudentByName(string name)
        {
            try
            {
                var response = await routes_const.SearchStudentByName
                     .SetQueryParam("name", name)
                     .GetJsonAsync<IEnumerable<EtudiantMixedDto>>();
                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Gérer l'exception ou la journaliser
                Console.WriteLine($"Erreur lors de la requête GET: {ex.Message}");
                throw;
            }
            throw new NotImplementedException();
        }
    }
}
