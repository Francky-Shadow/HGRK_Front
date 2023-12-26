using Flurl.Http;
using hgrkapp.DTO;
using hgrkapp.Repository.IServices;
using hgrkapp.Routes;

namespace hgrkapp.Repository.Services
{
    public class StageService : IStageService
    {
        public async Task<stage> CreateStage(stage stage)
        {
            try
            {

                var response = await routes_const.CreateStage
                     .PostJsonAsync(stage)
                     .ReceiveJson<stage>();
                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Handle the exception or log it
                Console.WriteLine($"Error during POST request: {ex.Message}");
                throw;
            }
        }

        public async Task<List<stage>> GetAllStage()
        {
            try
            {
                var response = await routes_const.GetAllStage
                     .GetJsonAsync<List<stage>>();
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
