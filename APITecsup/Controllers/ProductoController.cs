using APITecsup.Models.Request;
using APITecsup.Models.Response;
using Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace APITecsup.Controllers
{
    public class ProductoController : ApiController
    {
        // GET: api/Producto
        public List<ProductoResponse> Get()
        {

            var service = new ProductoService();
            var productos = service.Get();

            //Convert Domaint to Response
            var response = productos.Select(x => new ProductoResponse
            {
                ID = x.ID,
                Nombre = x.Nombre,
                Descripcion = x.Descripcion,
                PrecioVenta = x.PrecioVenta,
                FechaCreacion = x.FechaCreacion,
                FechaVencimiento = x.FechaVencimiento,
                IGV = x.PrecioVenta*0.18
            }).ToList();

            return response;
        }

        // GET: api/Producto/5
        public List<ProductoResponse> GetById(int id)
        {

            var service = new ProductoService();
            var productos = service.GetById(id);

            //Convert Domaint to Response
            var response = productos.Select(x => new ProductoResponse
            {
                ID = x.ID,
                Nombre = x.Nombre,
                Descripcion = x.Descripcion,
                PrecioVenta = x.PrecioVenta,
                FechaCreacion = x.FechaCreacion,
                FechaVencimiento = x.FechaVencimiento,
                IGV = x.PrecioVenta * 0.18
            }).ToList();

            return response;
        }

        [HttpPost]
        // POST: api/Producto
        public bool Insert(ProductoRequest request)
        {
            var response = true;
            try
            {
                var service = new ProductoService();
                service.Insert(new Domain.Producto
                {
                    Nombre = request.Nombre,
                    Descripcion = request.Descripcion,
                    PrecioVenta = request.PrecioVenta,
                    IGV = request.PrecioVenta * 0.18
                });
            }
            catch (Exception)
            {
                //log ex
                response = false;
            }
            return response;
        }

        [HttpPut]
        // PUT: api/Producto/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Producto/5
        public void Delete(int id)
        {
        }
    }
}
