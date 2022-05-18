using System.Collections.Generic;

namespace WebApplication2.Models.DTOs
{
    public class PedidoRequestDTO
    {

        public int IdCliente { get; set; }

        public int IdVendedor { get; set; }
        public List<PedidoDetalleRequestDTO> Pedidos { get; set; }
    }
}