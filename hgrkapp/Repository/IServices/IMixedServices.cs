using hgrkapp.DTO;

namespace hgrkapp.Repository.IServices
{
    public interface IMixedServices
    {
        Task<IEnumerable<EtudiantMixedDto>> GetMixedServicesAsync();
        Task<List<UniversiteStageDto>> GetUniversiteStageAsync();
    }
}
