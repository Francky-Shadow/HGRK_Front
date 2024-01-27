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
        public List<string> Validate()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(LabelGp))
            {
                errors.Add("Le champ Label groupe est obligatoire.");
            }

            if (string.IsNullOrEmpty(Code.ToString()))
            {
                errors.Add("Le champ Code du groupe est obligatoire.");
            }


            if (IdUniversite <= 0 || string.IsNullOrEmpty(IdUniversite.ToString()))
            {
                errors.Add("Veuillez sélectionner une université.");
            }

          
            return errors;
        }
    }
}
