namespace hgrkapp.DTO
{
    public class PaiementMixedDto
    {
        public long IdPaiement { get; set; }

        public string? RtxNum { get; set; }

        public DateTime? DatePaiement { get; set; }

        public double? Montant { get; set; }

        public string? TypePaiement { get; set; }

        public long IdEtudiant { get; set; }

        public string? NomEtudiant { get; set; }

        public string? PostnomEtudiant { get; set; }

        public string? PrenomEtudiant { get; set; }

        public DateTime? DateNaissance { get; set; }

        public string? LabelGp { get; set; }

        public string? CodeGp { get; set; }

        public string? EtatStage { get; set; }

        public string? PhotoUrl { get; set; }

        public string? NomUniversite { get; set; }

        public long? IdStage { get; set; }

        public long? IdUniversite { get; set; }
    }
}
