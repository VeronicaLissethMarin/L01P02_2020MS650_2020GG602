﻿using System.ComponentModel.DataAnnotations;
namespace L01P02_2020MS650_2020GG602.Models
{
    public class pedidos
    {
        [Key]
        public int pedidoId { get; set; }
        public int motoristaId { get; set; }
        public int clienteId { get; set; }
        public int platoId { get; set; }
        public int cantidad { get; set; }
        public int precio { get; set; }
    }
}
