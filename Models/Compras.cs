using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCursoE_commerce.Models
{
    public class Compras
    {
        [Key]
        public int CompraId { get; set; }
        public int UsuarioId { get; set; }
        public string CuentaUsuario { get; set; }
        public decimal precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Envio { get; set; }
        public decimal PrecioTotal { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int ProductoId { get; set; }
        public int VendedorId { get; set; }
        public string DireccionOrigen { get; set; }
        public double LatitudOrigen { get; set; }
        public double LongitudOrigen { get; set; }
        public string DireccionDestino { get; set; }
        public double LatitudDestino { get; set; }
        public double LongitudDestino { get; set; }
       
    }
}
