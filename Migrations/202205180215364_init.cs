namespace WebApplication2.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedidos",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    MontoTotal = c.Double(nullable: false),
                    IdCliente = c.Int(nullable: false),
                    IdVendedor = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personas", t => t.IdCliente, cascadeDelete: false)
                .ForeignKey("dbo.Personas", t => t.IdVendedor, cascadeDelete: false)
                .Index(t => t.IdCliente)
                .Index(t => t.IdVendedor);

            CreateTable(
                "dbo.Personas",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Identidad = c.String(),
                    Email = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.PedidoDetalles",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Cantidad = c.Int(nullable: false),
                    IdPedido = c.Int(nullable: false),
                    IdProducto = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pedidos", t => t.IdPedido, cascadeDelete: true)
                .ForeignKey("dbo.Productos", t => t.IdProducto, cascadeDelete: true)
                .Index(t => t.IdPedido)
                .Index(t => t.IdProducto);

            CreateTable(
                "dbo.Productos",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Monto = c.Double(nullable: false),
                    NombreProducto = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.PedidoDetalles", "IdProducto", "dbo.Productos");
            DropForeignKey("dbo.PedidoDetalles", "IdPedido", "dbo.Pedidos");
            DropForeignKey("dbo.Pedidos", "IdVendedor", "dbo.Personas");
            DropForeignKey("dbo.Pedidos", "IdCliente", "dbo.Personas");
            DropIndex("dbo.PedidoDetalles", new[] { "IdProducto" });
            DropIndex("dbo.PedidoDetalles", new[] { "IdPedido" });
            DropIndex("dbo.Pedidos", new[] { "IdVendedor" });
            DropIndex("dbo.Pedidos", new[] { "IdCliente" });
            DropTable("dbo.Productos");
            DropTable("dbo.PedidoDetalles");
            DropTable("dbo.Personas");
            DropTable("dbo.Pedidos");
        }
    }
}
