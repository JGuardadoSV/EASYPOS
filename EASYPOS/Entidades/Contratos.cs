using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class Contratos
    {
        public int IdContrato { get; set; }
        public string NombreCompleto { get; set; }
        public string Dui { get; set; }
        public string Nit { get; set; }
        public string TelefonoFijo { get; set; }
        public string Celular { get; set; }
        public string DireccionCasa { get; set; }
        public string DireccionTrabajo { get; set; }
        public string TelefonoTrabajo { get; set; }
        public string Referencia1 { get; set; }
        public string DireccionReferencia1 { get; set; }
        public string TelefonoReferencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string DireccionReferencia2 { get; set; }
        public string TelefonoReferencia2 { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Prima { get; set; }
        public decimal? Financiamiento { get; set; }
        public decimal? Cuota { get; set; }
        public decimal? GastosEscritura { get; set; }
        public decimal? PrimaNeta { get; set; }
        public decimal? PrimaInicial { get; set; }
        public string DescripcionProducto { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Chasis { get; set; }
        public int? Anio { get; set; }
        public DateTime? Fecha { get; set; }
        public string DuiReferencia { get; set; }
        public string NitReferencia { get; set; }
        public int Meses { get; set; }
        public int Estado { get; set; }
        public DateTime? FechaInicio { get; set; }

        public string NombreReferenciaFamiliar1 { get; set; }
        public string DireccionReferenciaFamiliar1 { get; set; }
        public string TelefonoFamiliar1 { get; set; }
        public string ParentescoFamiliar1 { get; set; }

        public string NombreReferenciaFamiliar2 { get; set; }
        public string DireccionReferenciaFamiliar2 { get; set; }
        public string TelefonoFamiliar2 { get; set; }
        public string ParentescoFamiliar2 { get; set; }
    }
}
