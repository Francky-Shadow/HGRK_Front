namespace hgrkapp.Routes
{
    public static class routes_const
    {
        //public static string Base = "https://localhost:7233/";
        public static string Base = "https://localhost:44375/";

        public static string clientToken = "e27049fe-b8d3-4a40-b73d-967cdd21b4ee";

        public static string GetGroupes= string.Concat(Base, "api/Groupes");
        public static string CreateGroupe = string.Concat(Base, "api/Groupes");

        public static string GetUniversite = string.Concat(Base, "api/Universites");
        public static string CreateUniversite = string.Concat(Base, "api/Universites");


        public static string GetAllStage = string.Concat(Base, "api/Stages");
        public static string CreateStage = string.Concat(Base, "api/Stages");


        public static string GetStudent = string.Concat(Base, "api/Etudiants");
        public static string CreateStudent = string.Concat(Base, "api/Etudiants");


        public static string MixedDataEtudiant = string.Concat(Base, "api/MixedData/student");
        public static string MixedDataUniversiteStage = string.Concat(Base, "api/MixedData/stages");


        //Routes pour les paiements
        public static string CreateNewPaiment = string.Concat(Base, "api/Paiements");
        public static string GetPaiements = string.Concat(Base, "api/Paiements");
        public static string GetMixedDataPaiement = string.Concat(Base, "api/MixedData/paiements");


        //Routes départements

        public static string CreateDepartement = string.Concat(Base, "api/Departements");
        public static string GetDepartement = string.Concat(Base, "api/Departements");


        //SearchMethods

        public static string SearchStudentByName = string.Concat(Base, "api/Etudiants/recherche/");

        public static string Login = string.Concat(Base, "api/Authentication/Login");
    }
}
