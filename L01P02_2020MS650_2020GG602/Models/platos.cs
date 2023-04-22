using System.ComponentModel.DataAnnotations;
namespace L01P02_2020MS650_2020GG602.Models
{
    public class platos
    {
        [Key]
        [Display(Name = "ID de plato")]
        public int platoId { get; set; }
        [Display(Name = "Nombre")]
        public string nombrePlato { get; set; }
        [Display(Name = "Precio")]
        public int precio { get; set; }
    }
}
