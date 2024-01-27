namespace hgrkapp.DTO
{
    public class session
    {
        public long Id { get; set; }

        public int? Rang { get; set; }

        public DateTime? DateDebut { get; set; }

        public DateTime? DateFin { get; set; }

        public string? IdDepartement { get; set; }

        public string? NomDepartement { get; set; }

        public long? IdStage { get; set; }

        public long? IdGroupe { get; set; }

        public string? EtatStage { get; set; }
    }
}
