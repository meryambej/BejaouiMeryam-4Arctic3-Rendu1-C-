using System.ComponentModel.DataAnnotations;

namespace Examen.ApplicationCore.Domain
{
    public class Patient
    {
        [Key]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Le code patient doit avoir exactement 5 caractères.")]
        public string CodePatient { get; set; }
        public string EmailPatient { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Informations supplémentaires")]
        public string Informations { get; set; }
        public string NomComplet { get; set; }
        public string NumeroTel { get; set; }

        // many bilans
        public ICollection<Bilan> Bilans { get; set; }

        // many infirmer
        public ICollection<Infirmier> Infirmiers { get; set; }
    }
}
