using System;
using System.Collections.Generic;

namespace Consultorio_Dental_San_Juan_Sur_Solucion_WEB.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string? ProductoNombre { get; set; }

    public string? ProductoDescripcion { get; set; }

    public decimal? ProductoPrecio { get; set; }

    public TimeOnly? FechaDeIngreso { get; set; }

    public int? CantidadStock { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
