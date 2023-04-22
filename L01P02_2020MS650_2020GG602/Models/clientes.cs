using System.ComponentModel.DataAnnotations;
namespace L01P02_2020MS650_2020GG602.Models
{
    public class clientes
    {
        [Key]
        public int clienteId { get; set; }
        public string? nombreCliente { get; set; }
        public string? direccion { get; set; }

    }
}
