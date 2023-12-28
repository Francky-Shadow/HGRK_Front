using Flurl.Http;
using hgrkapp.DTO;
using hgrkapp.Repository.IServices;
using hgrkapp.Routes;

namespace hgrkapp.Repository.Services
{
    public class MixedServices : IMixedServices
    {
        public async Task<IEnumerable<EtudiantMixedDto>> GetMixedServicesAsync()
        {
            try
            {
                var response = await routes_const.MixedDataEtudiant
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

        public async Task<List<UniversiteStageDto>> GetUniversiteStageAsync()
        {
            try
            {
                var response = await routes_const.MixedDataUniversiteStage
                     .GetJsonAsync<List<UniversiteStageDto>>();
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
