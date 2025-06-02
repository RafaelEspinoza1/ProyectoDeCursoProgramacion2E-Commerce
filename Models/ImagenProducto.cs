using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCursoE_commerce.Models
{
    public class ImagenProducto
    {
        [Key]
            public int ImagenId { get; set; }
            public int ProductoId { get; set; } // clave foránea
            public byte[] Imagen { get; set; }
        public Productos Producto { get; set; }

    }
}
