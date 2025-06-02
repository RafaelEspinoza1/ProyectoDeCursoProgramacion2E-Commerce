using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCursoE_commerce.Models
{
    public class IngresosECommerce
    {
        [Key]
        public int IngresoId { get; set; }
        public decimal Cantidad { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioId { get; set; } // Clave foránea a la tabla Vendedores
        public DateTime Fecha { get; set; } = DateTime.Now;
        [ForeignKey("UsuarioId")]

        public Usuarios Usuario { get; set; } // Navegación a la entidad Vendedores

    }
}
