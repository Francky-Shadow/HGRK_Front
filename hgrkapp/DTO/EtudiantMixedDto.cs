namespace hgrkapp.DTO
{
    public class EtudiantMixedDto
    {
        public long IdEtudiant { get; set; }

        public string? NomEtudiant { get; set; }

        public string? PostnomEtudiant { get; set; }

        public string? PrenomEtudiant { get; set; }

        public DateTime? DateNaissanceEtudiant { get; set; }

        public string? Sexe { get; set; }

        public bool? Apaye { get; set; }

        public string? EtatStageEtudiant { get; set; }

        public string? PhotoUrl { get; set; }

        public long? IdUniversite { get; set; }

        public long? IdGroupe { get; set; }

        public long? IdStage { get; set; }

        public string? Autres { get; set; }

        public string? LabelGp { get; set; }
        public int? CodeGp { get; set; }
        public DateTime? DateCreationGp { get; set; }
        public string NomUniversite { get; set; } = null!;

        public DateTime? DateRequeranc { get; set; }

        public string? AdresseUniversite { get; set; }
    }
}
