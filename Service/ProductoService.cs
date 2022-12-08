using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductoService
    {
        public List<Producto> Get()
        {
            using (var context = new ExampleContext())
            {
                return context.Productoes.Where(x => x.EstaActivo == true).ToList();
            }
        }

        public List<Producto> GetById(int id)
        {
            using (var context = new ExampleContext())
            {
                return context.Productoes.Where(x => x.ID == id).ToList();
            }
        }


        public void Insert(Producto producto)
        {
            using (var context = new ExampleContext())
            {

                producto.EstaActivo = true;
                producto.FechaCreacion = DateTime.Today;
                producto.FechaVencimiento = DateTime.Today.AddMonths(12);
                context.Productoes.Add(producto);
                context.SaveChanges();
            }
        }
    }
}
