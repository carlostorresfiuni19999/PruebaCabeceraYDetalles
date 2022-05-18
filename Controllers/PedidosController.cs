using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication2.Data;
using WebApplication2.Models.DTOs;
using WebApplication2.Models.Entities;

namespace WebApplication2.Controllers
{
    public class PedidosController : ApiController
    {
        private WebApplication2Context db = new WebApplication2Context();




        [HttpGet]
        [Route("api/GetPeople")]
        public List<Persona> GetPersonas()
        {
            return db.Personas.ToList();
        }

        [HttpGet]
        [Route("api/GetProducts")]
        public List<Producto> GetProducts()
        {
            return db.Productos.ToList();
        }

        // GET: api/Pedidos
        public List<FullPedidoResponseDTO> GetFullPedidos()
        {
            return db.Pedidos
                .Include(v => v.Vendedor)
                .Include(c => c.Cliente)
                .ToList()
                .ConvertAll(p => MapToFullDTO(p));
        }



        // GET: api/Pedidos/5
        [ResponseType(typeof(FullPedidoResponseDTO))]
        public IHttpActionResult GetPedido(int id)
        {
            Pedido pedido = db.Pedidos
                .Include(c => c.Cliente)
                .Include(v => v.Vendedor)
                .FirstOrDefault(p => p.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return Ok(MapToFullDTO(pedido));
        }


        // POST: api/Pedidos
        [ResponseType(typeof(PedidoRequestDTO))]
        public IHttpActionResult PostPedido(PedidoRequestDTO pedido)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Validamos las entradas
            var Cliente = db.Personas.Find(pedido.IdCliente);
            var Vendedor = db.Personas.Find(pedido.IdVendedor);
            if (Cliente == null) return BadRequest("No existe cliente");
            if (Vendedor == null) return BadRequest("No existe Vendedor");

            //Cargamos primero la Cabecera;

            var PedidoDb = new Pedido
            {
                IdCliente = Cliente.Id,
                IdVendedor = Vendedor.Id,
                MontoTotal = 0.0 //Por ahora es 0
            };

            /*Esto solo guarda en el context, pero no
			  En la base de datos, Tambien guardamos
			la instancia, necesitaremos el Id, Mas tarde
			*/
            var PedidoSaved = db.Pedidos.Add(PedidoDb);

            //Declaramos la variable Monto
            double Monto = 0;

            //Iteramos sobre cada Lista de Detalles

            foreach (var detalle in pedido.Pedidos)
            {
                //Obtenemos el producto por su Id
                var Producto = db.Productos.Find(detalle.IdProducto);

                //calculamos el monto total del pedido

                Monto += Producto.Monto * detalle.Cantidad;

                // Ya que estamos iterando, creamos los Pedidos Detalles

                var PedidoDetalleDB = new PedidoDetalle
                {
                    IdPedido = PedidoSaved.Id, // Le pasamos el Id de la cabecera que guardamos anteriormente
                    IdProducto = detalle.IdProducto,
                    Cantidad = detalle.Cantidad
                };

                //Guardamos en el contexto
                db.PedidosDetalles.Add(PedidoDetalleDB);
            }

            //Volvemos a setear El Monto Total de la Cabecera
            PedidoDb.MontoTotal = Monto;
            /*
			 * Usamos Added porque solo existe en el contexto y no
			 * en la base de datos, si existe en la base de datos,
			 * usaremos EntityState.Modified
			 */
            db.Entry(PedidoDb).State = EntityState.Added;

            try
            {
                //Guardamos todos los cambios

                db.SaveChanges();
                return Ok("Guardado con exito");
            }
            catch (Exception ex)
            {
                //Si ocurre un error, retornamos un BadRequst
                //Se revierten todos los cambios
                return BadRequest("Error en la transaccion: " + ex.Message);
            }

        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PedidoExists(int id)
        {
            return db.Pedidos.Count(e => e.Id == id) > 0;
        }
        /*
		 * Esta funcion Precarga a todas las Personas
		 */


        private FullPedidoResponseDTO MapToFullDTO(Pedido entity)
        {
            return new FullPedidoResponseDTO
            {
                Cliente = entity.Cliente,
                Vendedor = entity.Vendedor,
                MontoTotal = entity.MontoTotal,
                Detalles = db.PedidosDetalles
                .Include(p => p.Pedido)
                .Include(pr => pr.Producto)
                .Where(pd => pd.IdPedido == entity.Id)
                .ToList()
                .ConvertAll(pd => new FullPedidoDetalleResponseDTO
                {
                    Cantidad = pd.Cantidad,
                    Producto = pd.Producto
                })
            };
        }




    }


}