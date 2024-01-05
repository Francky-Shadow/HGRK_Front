namespace hgrkapp.DTO
{
    public class paiement
    {
        public long Id { get; set; }

        public string? RtxNum { get; set; }

        public DateTime? DatePaiement { get; set; }

        public double? Montant { get; set; }

        public string? TypePaiement { get; set; }

        public long IdEtudiant { get; set; }
        public string? Autres { get; set; }

    }
}
