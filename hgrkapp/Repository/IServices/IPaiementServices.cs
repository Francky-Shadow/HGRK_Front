using hgrkapp.DTO;

namespace hgrkapp.Repository.IServices
{
    public interface IPaiementServices
    {
        Task<paiement> CreatePaiment(paiement paiement);
        Task<List<PaiementMixedDto>> GetPaiements();
    }
}
