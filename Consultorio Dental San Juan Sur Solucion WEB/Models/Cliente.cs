using System;
using System.Collections.Generic;

namespace Consultorio_Dental_San_Juan_Sur_Solucion_WEB.Models;

public partial class Cliente
{
    public int ClienteCedula { get; set; }

    public string? NombreCs { get; set; }

    public string? ApellidoCs { get; set; }

    public string? NtelefonoCs { get; set; }

    public DateOnly? FechaNacimientoCs { get; set; }

    public string? CorreoCs { get; set; }

    public string? ContraseñaCs { get; set; }

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public virtual ICollection<Expediente> Expedientes { get; set; } = new List<Expediente>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
