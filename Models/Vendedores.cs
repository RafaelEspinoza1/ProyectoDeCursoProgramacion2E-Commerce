using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCursoE_commerce.Models
{
    public class Vendedores
    {
        [Key]
        public int VendedorId { set; get; }
        public string NumeroDeCuenta { set; get; }
        public decimal Ingresos { set; get; }
        public int UsuarioID { set; get; }
        public string direccionOrigen { set; get; }
        public double LatitudOrigen { get; set; }
        public double LongitudOrigen { get; set; }
        public Usuarios Usuario { set; get; }


    }
}
