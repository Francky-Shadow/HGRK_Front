using Blazorise;
using hgrkapp.DTO;

namespace hgrkapp.Validations
{
    public class GroupeValidation
    {
        groupe groupclass= new groupe();
        public List<string> Validate()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(groupclass.LabelGp))
            {
                errors.Add("Le champ Label groupe est obligatoire.");
            }

            if (string.IsNullOrEmpty(groupclass.Code.ToString()))
            {
                errors.Add("Le champ Code du groupe est obligatoire.");
            }

            if (string.IsNullOrEmpty(groupclass.DateCreation.ToString()))
            {
                errors.Add("Le champ Date de création est obligatoire.");
            }

            if (groupclass.IdUniversite <= 0 || string.IsNullOrEmpty(groupclass.IdUniversite.ToString()))
            {
                errors.Add("Veuillez sélectionner une université.");
            }

            if (string.IsNullOrEmpty(groupclass.EtatStage))
            {
                errors.Add("Veuillez sélectionner l'état du stage.");
            }

            return errors;
        }
    }
}
