using System;
using System.Collections.Generic;

namespace Consultorio_Dental_San_Juan_Sur_Solucion_WEB.Models;

public partial class Factura
{
    public int FacturaId { get; set; }

    public DateOnly? FechaFactu { get; set; }

    public double? TotalFact { get; set; }

    public int? ClienteId { get; set; }

    public int? ProductoId { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Producto? Producto { get; set; }
}
