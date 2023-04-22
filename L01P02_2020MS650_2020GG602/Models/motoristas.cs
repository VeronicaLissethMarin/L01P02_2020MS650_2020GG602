using System.ComponentModel.DataAnnotations;
namespace L01P02_2020MS650_2020GG602.Models
{
    public class motoristas
    {
        [Key]
        [Display(Name = "ID del Motorista")]
        public int motoristaId { get; set; }
        [Display(Name = "Nombre")]
        public string? nombreMotorista { get; set; }

    }
}
