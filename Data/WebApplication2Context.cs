﻿using System.Data.Entity;

namespace WebApplication2.Data
{
    public class WebApplication2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public WebApplication2Context() : base("name=WebApplication2Context")
        {
        }

        public System.Data.Entity.DbSet<WebApplication2.Models.Entities.Pedido> Pedidos { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.Entities.Persona> Personas { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.Entities.Producto> Productos { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.Entities.PedidoDetalle> PedidosDetalles { get; set; }

    }
}