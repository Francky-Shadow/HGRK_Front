using hgrkapp.DTO;

namespace hgrkapp.Repository.IServices
{
    public interface IAuthenticationService
    {
        Task<LoginResult> Login(User user);
        Task<RegisterResponse> Register(User user);
        Task Logout();
    }
}
