using hgrkapp.DTO;

namespace hgrkapp.Repository.IServices
{
    public interface ICountServices
    {
        Task<CountDto> GetCountsInEnCoursAsync();
    }
}
