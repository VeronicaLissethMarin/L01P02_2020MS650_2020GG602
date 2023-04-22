using System.ComponentModel.DataAnnotations;
namespace L01P02_2020MS650_2020GG602.Models
{
    public class pedidos
    {
        [Key]
        [Display(Name = "ID de pedido")]
        public int pedidoId { get; set; }
        [Display(Name = "ID de motorista")]
        public int? motoristaId { get; set; }
        [Display(Name = "ID de cliente")]
        public int? clienteId { get; set; }
        [Display(Name = "ID de plato")]
        public int? platoId { get; set; }
        [Display(Name = "Cantidad")]
        public int cantidad { get; set; }
        [Display(Name = "Precio")]
        public int precio { get; set; }
    }
}
