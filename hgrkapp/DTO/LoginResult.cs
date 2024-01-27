namespace hgrkapp.DTO
{
    public class LoginResult
    {
        public string? token { get; set; }
        public bool Successful { get; set; }
        public string ErrorMsg { get; set; }
    }
}
