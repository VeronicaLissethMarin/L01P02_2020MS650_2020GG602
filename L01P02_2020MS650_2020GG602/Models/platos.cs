using System.ComponentModel.DataAnnotations;
namespace L01P02_2020MS650_2020GG602.Models
{
    public class platos
    {
        [Key]
        public int platoId { get; set; }
        public string? nombrePlato { get; set; }
        public int precio { get; set; }
    }
}
