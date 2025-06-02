using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using ProyectoDeCursoE_commerce.Models;

namespace ProyectoDeCursoE_commerce.Data
{
    public class ECommerceContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<ImagenProducto> ImagenesProductos { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<IngresosECommerce> IngresosECommerce { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =RAFAELESPINOZA\SQLSERVER2019; database = ECommerce; trusted_Connection = true; trustserverCertificate = true;");
        }
    }
}
