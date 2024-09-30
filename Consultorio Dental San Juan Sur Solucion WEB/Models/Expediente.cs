using System;
using System.Collections.Generic;

namespace Consultorio_Dental_San_Juan_Sur_Solucion_WEB.Models;

public partial class Expediente
{
    public int ExpedienteId { get; set; }

    public int? ClienteExId { get; set; }

    public DateOnly? FechaDeActualizacion { get; set; }

    public string? ComentariosExp { get; set; }

    public int? EncargadoEmpId { get; set; }

    public virtual Cliente? ClienteEx { get; set; }

    public virtual Empleado? EncargadoEmp { get; set; }
}
