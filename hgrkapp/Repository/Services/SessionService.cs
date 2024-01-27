using Flurl.Http;
using hgrkapp.DTO;
using hgrkapp.Repository.IServices;
using hgrkapp.Routes;

namespace hgrkapp.Repository.Services
{
    public class SessionService : ISessionServices
    {
        public async Task<session> CreateSession(session session)
        {
            try
            {

                var response = await routes_const.GetSessionStage
                     .PostJsonAsync(session)
                     .ReceiveJson<session>();
                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Handle the exception or log it
                Console.WriteLine($"Error during POST request: {ex.Message}");
                throw;
            }
        }

        public async Task<List<session>> GetSession()
        {
            try
            {
                var response = await routes_const.GetSessionStage
                     .GetJsonAsync<List<session>>();
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
