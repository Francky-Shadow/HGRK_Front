using hgrkapp.DTO;

namespace hgrkapp.Repository.IServices
{
    public interface IGroupeServices
    {
        Task<List<groupe>> GetGroupes();
        
    }
}
