using System;
using System.Collections.Generic;

namespace Consultorio_Dental_San_Juan_Sur_Solucion_WEB.Models;

public partial class Citum
{
    public int CitaId { get; set; }

    public TimeOnly? FechaCita { get; set; }

    public int? Cliente { get; set; }

    public int? Empleado { get; set; }

    public string? Estado { get; set; }

    public string? Motivo { get; set; }

    public string? Comentarios { get; set; }

    public virtual Cliente? ClienteNavigation { get; set; }

    public virtual Empleado? EmpleadoNavigation { get; set; }
}
