using Flurl.Http;
using hgrkapp.DTO;
using hgrkapp.Repository.IServices;
using hgrkapp.Routes;

namespace hgrkapp.Repository.Services
{
    public class UniversiteServices : IUniversiteServices
    {
        public async Task<universite> CreateUniversite(universite universite)
        {
            try
            {
               
                var response = await routes_const.CreateUniversite
                     .PostJsonAsync(universite)
                     .ReceiveJson<universite>();
                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Handle the exception or log it
                Console.WriteLine($"Error during POST request: {ex.Message}");
                throw;
            }
          
        }

        public async Task<List<universite>> GetUniversite()
        {
            try
            {
                var response = await routes_const.GetUniversite
                     .GetJsonAsync<List<universite>>();
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
