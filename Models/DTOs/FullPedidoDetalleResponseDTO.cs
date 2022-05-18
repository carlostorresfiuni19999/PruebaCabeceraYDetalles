using WebApplication2.Models.Entities;

namespace WebApplication2.Models.DTOs
{
    public class FullPedidoDetalleResponseDTO
    {
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }
    }
}