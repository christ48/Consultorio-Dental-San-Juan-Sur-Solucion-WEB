using System;
using System.Collections.Generic;

namespace Consultorio_Dental_San_Juan_Sur_Solucion_WEB.Models;

public partial class Empleado
{
    public int EmpleadoCedula { get; set; }

    public string? NombreEm { get; set; }

    public string? ApellidoEm { get; set; }

    public TimeOnly? HoraDeEntrada { get; set; }

    public TimeOnly? HoraDeSalida { get; set; }

    public DateOnly? FechaDeNacimientoEm { get; set; }

    public string? NtelefonoEm { get; set; }

    public string? CorrereoEm { get; set; }

    public string? ContraseñaEm { get; set; }

    public double? SalarioEm { get; set; }

    public string? PuestoEm { get; set; }

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    public virtual ICollection<Expediente> Expedientes { get; set; } = new List<Expediente>();
}
