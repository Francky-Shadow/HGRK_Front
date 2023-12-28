namespace hgrkapp
{
    public class UniversiteStageDto
    {
        public long IdStage { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string EtatStage { get; set; }
        public long IdUniversite { get; set; }
        public string NomUniversite { get; set; }
        public int NombreEtudiants { get; set; }

    }
}
