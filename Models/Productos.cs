using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCursoE_commerce.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }
        public int VendedorId { get; set; }
        [ForeignKey("VendedorId")]

        public Vendedores Vendedor { get; set; }

        public List<ImagenProducto> Imagenes { get; set; } = new List<ImagenProducto>();
        

    }
}
