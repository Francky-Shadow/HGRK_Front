using Flurl;
using Flurl.Http;
using hgrkapp.DTO;
using hgrkapp.Pages;
using hgrkapp.Repository.IServices;
using hgrkapp.Routes;
using System.Xml.Linq;

namespace hgrkapp.Repository.Services
{
    public class DepartementServices : IDepartementServices
    {
        public async Task<departement> CreateDepartement(departement departement)
        {
            try
            {

                var response = await routes_const.CreateDepartement
                     .PostJsonAsync(departement)
                     .ReceiveJson<departement>();
                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Handle the exception or log it
                Console.WriteLine($"Error during POST request: {ex.Message}");
                throw;
            }
        }

        public async Task<List<departement>> GetDDepartements()
        {
            try
            {
                var response = await routes_const.GetDepartement
                     .GetJsonAsync<List<departement>>();
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

        public async Task<departement> UpdateDepartement(int id, departement departement)
        {
            try
            {
                var response = await routes_const.GetDepartement
                    .AppendPathSegment(id.ToString())
                    .PutJsonAsync(departement)
                    .ReceiveJson<departement>();

                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Gérer les erreurs HTTP
                // ex.Message contient des informations sur l'erreur
                throw;
            }
            catch (Exception ex)
            {
                // Gérer d'autres exceptions
                throw;
            }
        }
    }
}
