namespace hgrkapp.DTO
{
    public class universite
    {
        public long Id { get; set; }

        public string Nom { get; set; } = null!;

        public DateTime? DateRequeranc { get; set; }

        public string? Adresse { get; set; }
    }
}
