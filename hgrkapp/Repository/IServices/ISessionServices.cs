using hgrkapp.DTO;
using hgrkapp.Layout;

namespace hgrkapp.Repository.IServices
{
    public interface ISessionServices
    {
        Task<session> CreateSession(session session);
        Task<List<session>> GetSession();
    }
}
