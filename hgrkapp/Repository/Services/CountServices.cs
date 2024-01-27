using Flurl.Http;
using hgrkapp.DTO;
using hgrkapp.Repository.IServices;
using hgrkapp.Routes;

namespace hgrkapp.Repository.Services
{
    public class CountServices : ICountServices
    {
        public async Task<CountDto> GetCountsInEnCoursAsync()
        {
            try
            {
                var response = await routes_const.GetCountData
                   
                    .GetJsonAsync<CountDto>();

                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Handle exceptions or log errors as needed
                throw;
            }
        }
    }
}
