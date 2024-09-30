using System;
using System.Collections.Generic;

namespace Consultorio_Dental_San_Juan_Sur_Solucion_WEB.Models;

public partial class Comentario
{
    public int ComentarioId { get; set; }

    public int? ClienteCtId { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    public string? Comentario1 { get; set; }

    public virtual Cliente? ClienteCt { get; set; }
}
