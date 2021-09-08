using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entietes
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public DateTime Vencimiento { get; set; }
        public UnidadMedida UnidadMedida { get; set; }
    }
}
