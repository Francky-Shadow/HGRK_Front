using Flurl.Http;
using hgrkapp.DTO;
using hgrkapp.Repository.IServices;
using hgrkapp.Routes;
using System.Text.RegularExpressions;

namespace HGRK.Repository.Services
{
    public class GroupeService : IGroupeServices
    {
        public async Task<groupe> CreateGroupe(groupe groupe)
        {
            try
            {

                var response = await routes_const.CreateGroupe
                     .PostJsonAsync(groupe)
                     .ReceiveJson<groupe>();
                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Handle the exception or log it
                Console.WriteLine($"Error during POST request: {ex.Message}");
                throw;
            }
        }

        public async Task<List<groupe>> GetGroupes()
        {
            try
            {
               var response = await routes_const.GetGroupes
                    .GetJsonAsync<List<groupe>>();
                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Gérer l'exception ou la journaliser
                Console.WriteLine($"Erreur lors de la requête GET: {ex.Message}");
                throw;
            }
        }
    }
}
