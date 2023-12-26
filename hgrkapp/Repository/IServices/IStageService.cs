using hgrkapp.DTO;

namespace hgrkapp.Repository.IServices
{
    public interface IStageService
    {
        Task<List<stage>> GetAllStage();
        Task<stage> CreateStage(stage stage);
    }
}
