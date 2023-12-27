using hgrkapp.DTO;

namespace hgrkapp.Repository.IServices
{
    public interface IEtudiantServices
    {
        Task<List<etudiant>> GetEtudiantAsync();
        Task<etudiant> CreateEtudiantAsync(etudiant etudiant);
    }
}
