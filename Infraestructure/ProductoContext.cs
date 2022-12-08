using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Infraestructure
{
    public class ProductoContext : DbContext
    {
        public ProductoContext() : base("name = MyContextDB")
        {

        }
        public DbSet<Producto> Productos { get; set; }

    }
}
