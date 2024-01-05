using Flurl.Http;
using hgrkapp.DTO;
using hgrkapp.Repository.IServices;
using hgrkapp.Routes;

namespace hgrkapp.Repository.Services
{
    public class PaiementServices : IPaiementServices
    {
        public async Task<paiement> CreatePaiment(paiement paiement)
        {
            try
            {

                var response = await routes_const.CreateNewPaiment
                     .PostJsonAsync(paiement)
                     .ReceiveJson<paiement>();
                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Handle the exception or log it
                Console.WriteLine($"Error during POST request: {ex.Message}");
                throw;
            }
        }

        public async Task<List<PaiementMixedDto>> GetPaiements()
        {
            try
            {
                var response = await routes_const.GetMixedDataPaiement
                     .GetJsonAsync<List<PaiementMixedDto>>();
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
