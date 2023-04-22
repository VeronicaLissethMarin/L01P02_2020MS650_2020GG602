using System.ComponentModel.DataAnnotations;
namespace L01P02_2020MS650_2020GG602.Models
{
    public class clientes
    {
        [Key]
        [Display(Name = "ID de cliente")]
        public int clienteId { get; set; }
        [Display(Name = "Nombre")]
        public string? nombreCliente { get; set; }
        [Display(Name = "Dirección")]
        public string? direccion { get; set; }

    }
}
