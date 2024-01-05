namespace hgrkapp.Repository.IServices
{
    public interface ISearchServices
    {
        Task<ISearchServices> SearchStudentByName(string name);
    }
}
