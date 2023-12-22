using System.ComponentModel.DataAnnotations.Schema;

namespace hgrkapp.DTO
{
    public class groupe
    {
        public long Id { get; set; }
        public string? LabelGp { get; set; }
        public int? Code { get; set; }
        public DateTime? DateCreation { get; set; }
        public long? IdUniversite { get; set; }
        public string? EtatStage { get; set; }
    }
}
