using DevIO.Bussines.Models;

namespace DevIO.App.ViewModels
{
    public class ClinicaViewModel
    {
        public string Id;
        public string NomeClinica { get; set; }
        public List<Clinica> Consultas { get; set; }
    }
}