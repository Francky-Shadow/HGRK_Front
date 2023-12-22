using hgrkapp.DTO;

namespace hgrkapp.Repository.IServices
{
    public interface IUniversiteServices
    {
        Task<List<universite>> GetUniversite();
    }
}
