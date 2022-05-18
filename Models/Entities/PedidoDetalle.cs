using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models.Entities
{
    public class PedidoDetalle
    {
        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public int Cantidad { get; set; }

        public Producto Producto { get; set; }

        [ForeignKey("Pedido")]
        public int IdPedido { get; set; }
        [ForeignKey("Producto")]

        public int IdProducto { get; set; }
    }
}