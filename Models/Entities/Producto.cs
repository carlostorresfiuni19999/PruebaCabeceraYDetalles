using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models.Entities
{
    [Table("Productos")]
    public class Producto
    {
        public int Id { get; set; }
        public double Monto { get; set; }
        public string NombreProducto { get; set; }

    }
}