using hgrkapp.DTO;

namespace hgrkapp.Repository.IServices
{
    public interface IAuthenticationService
    {
        Task<LoginResult> Login(User user);
    }
}
