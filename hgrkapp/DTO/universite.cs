using Blazorise;
using hgrkapp.Pages;

namespace hgrkapp.DTO
{
    public class universite
    {
        public long Id { get; set; }

        public string Nom { get; set; } = null!;

        public DateTime? DateRequeranc { get; set; }

        public string? Adresse { get; set; }
        public List<string> Validate()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(Nom))
            {
                errors.Add("Le nom de l'université est obligatoire.");
            }

            if (string.IsNullOrEmpty(DateRequeranc.ToString()))
            {
                errors.Add("La Date de réquérance est obligatoire.");
            }


            if (string.IsNullOrEmpty(Adresse))
            {
                errors.Add("L'adresse est obligatoire");
            }


            return errors;
        }
    }
}
