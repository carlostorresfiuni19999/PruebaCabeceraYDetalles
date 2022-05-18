using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models.Entities
{
    [Table("Pedidos")]
    public class Pedido
    {
        public int Id { get; set; }
        public Persona Cliente { get; set; }
        public Persona Vendedor { get; set; }
        public double MontoTotal { get; set; }

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }

        [ForeignKey("Vendedor")]
        public int IdVendedor { get; set; }
    }
}