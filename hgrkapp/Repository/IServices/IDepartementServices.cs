using hgrkapp.DTO;

namespace hgrkapp.Repository.IServices
{
    public interface IDepartementServices
    {
        Task<departement> CreateDepartement(departement departement);
        Task<List<departement>> GetDDepartements();
        Task<departement> UpdateDepartement(int id,departement departement);
    }
}
