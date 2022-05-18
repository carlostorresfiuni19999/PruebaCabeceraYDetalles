using System.Collections.Generic;
using WebApplication2.Models.Entities;

namespace WebApplication2.Models.DTOs
{
    public class FullPedidoResponseDTO
    {
        public Persona Cliente { get; set; }
        public Persona Vendedor { get; set; }

        public double MontoTotal { get; set; }
        public List<FullPedidoDetalleResponseDTO> Detalles { get; set; }


    }
}