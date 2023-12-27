namespace hgrkapp.DTO
{
    public class etudiant
    {
        public long Id { get; set; }

        public string? Nom { get; set; }

        public string? Postnom { get; set; }

        public string? Prenom { get; set; }

        public DateTime? DateNaissance { get; set; }

        public string? Sexe { get; set; }

        public bool? Apaye { get; set; }

        public string? EtatStage { get; set; }

        public string? PhotoUrl { get; set; }

        public long? IdUniversite { get; set; }

        public long? IdGroupe { get; set; }

        public long? IdStage { get; set; }

        public string? Autres { get; set; }
    }
}
