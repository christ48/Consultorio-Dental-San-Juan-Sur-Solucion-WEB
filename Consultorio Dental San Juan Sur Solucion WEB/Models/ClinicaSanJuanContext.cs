using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Consultorio_Dental_San_Juan_Sur_Solucion_WEB.Models;

public partial class ClinicaSanJuanContext : DbContext
{
    public ClinicaSanJuanContext()
    {
    }

    public ClinicaSanJuanContext(DbContextOptions<ClinicaSanJuanContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Citum> Cita { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Comentario> Comentarios { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Expediente> Expedientes { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=localhost; database=Clinica_San_Juan; Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Citum>(entity =>
        {
            entity.HasKey(e => e.CitaId).HasName("PK__Cita__992C362D1D422E68");

            entity.Property(e => e.CitaId)
                .ValueGeneratedNever()
                .HasColumnName("Cita_id");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaCita).HasColumnName("fecha_cita");
            entity.Property(e => e.Motivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("motivo");

            entity.HasOne(d => d.ClienteNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.Cliente)
                .HasConstraintName("FK__Cita__Cliente__4316F928");

            entity.HasOne(d => d.EmpleadoNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.Empleado)
                .HasConstraintName("FK__Cita__Empleado__440B1D61");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteCedula).HasName("PK__Clientes__EA8F0266A76C3983");

            entity.Property(e => e.ClienteCedula)
                .ValueGeneratedNever()
                .HasColumnName("cliente_Cedula");
            entity.Property(e => e.ApellidoCs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Apellido_Cs");
            entity.Property(e => e.ContraseñaCs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Contraseña_CS");
            entity.Property(e => e.CorreoCs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Correo_CS");
            entity.Property(e => e.FechaNacimientoCs).HasColumnName("Fecha_Nacimiento_CS");
            entity.Property(e => e.NombreCs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Nombre_Cs");
            entity.Property(e => e.NtelefonoCs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NTelefono_CS");
        });

        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasKey(e => e.ComentarioId).HasName("PK__comentar__655655D15768A2EA");

            entity.ToTable("comentarios");

            entity.Property(e => e.ComentarioId)
                .ValueGeneratedNever()
                .HasColumnName("Comentario_id");
            entity.Property(e => e.ClienteCtId).HasColumnName("Cliente_Ct_id");
            entity.Property(e => e.Comentario1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Comentario");
            entity.Property(e => e.FechaCreacion).HasColumnName("fecha_Creacion");

            entity.HasOne(d => d.ClienteCt).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.ClienteCtId)
                .HasConstraintName("FK__comentari__Clien__46E78A0C");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.EmpleadoCedula).HasName("PK__Empleado__7C2A404AE13F464C");

            entity.ToTable("Empleado");

            entity.Property(e => e.EmpleadoCedula)
                .ValueGeneratedNever()
                .HasColumnName("Empleado_Cedula");
            entity.Property(e => e.ApellidoEm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Apellido_Em");
            entity.Property(e => e.ContraseñaEm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Contraseña_Em");
            entity.Property(e => e.CorrereoEm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Correreo_Em");
            entity.Property(e => e.FechaDeNacimientoEm).HasColumnName("Fecha_De_Nacimiento_Em");
            entity.Property(e => e.HoraDeEntrada).HasColumnName("hora_de_entrada");
            entity.Property(e => e.HoraDeSalida).HasColumnName("hora_de_salida");
            entity.Property(e => e.NombreEm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Nombre_Em");
            entity.Property(e => e.NtelefonoEm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Ntelefono_Em");
            entity.Property(e => e.PuestoEm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Puesto_Em");
            entity.Property(e => e.SalarioEm).HasColumnName("Salario_Em");
        });

        modelBuilder.Entity<Expediente>(entity =>
        {
            entity.HasKey(e => e.ExpedienteId).HasName("PK__Expedien__0AAA5B144E2B8BA3");

            entity.ToTable("Expediente");

            entity.Property(e => e.ExpedienteId)
                .ValueGeneratedNever()
                .HasColumnName("Expediente_id");
            entity.Property(e => e.ClienteExId).HasColumnName("Cliente_Ex_id");
            entity.Property(e => e.ComentariosExp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Comentarios_exp");
            entity.Property(e => e.EncargadoEmpId).HasColumnName("Encargado_Emp_id");
            entity.Property(e => e.FechaDeActualizacion).HasColumnName("Fecha_de_Actualizacion");

            entity.HasOne(d => d.ClienteEx).WithMany(p => p.Expedientes)
                .HasForeignKey(d => d.ClienteExId)
                .HasConstraintName("FK__Expedient__Clien__47DBAE45");

            entity.HasOne(d => d.EncargadoEmp).WithMany(p => p.Expedientes)
                .HasForeignKey(d => d.EncargadoEmpId)
                .HasConstraintName("FK__Expedient__Encar__48CFD27E");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.FacturaId).HasName("PK__facturas__EC67DFBD04BEDED4");

            entity.ToTable("facturas");

            entity.Property(e => e.FacturaId)
                .ValueGeneratedNever()
                .HasColumnName("Factura_id");
            entity.Property(e => e.ClienteId).HasColumnName("Cliente_id");
            entity.Property(e => e.FechaFactu).HasColumnName("fecha_factu");
            entity.Property(e => e.ProductoId).HasColumnName("producto_id");
            entity.Property(e => e.TotalFact).HasColumnName("Total_Fact");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__facturas__Client__45F365D3");

            entity.HasOne(d => d.Producto).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK__facturas__produc__44FF419A");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__Producto__FB5CEEECC15197B5");

            entity.Property(e => e.ProductoId)
                .ValueGeneratedNever()
                .HasColumnName("producto_id");
            entity.Property(e => e.CantidadStock).HasColumnName("Cantidad_stock");
            entity.Property(e => e.FechaDeIngreso).HasColumnName("fecha_de_ingreso");
            entity.Property(e => e.ProductoDescripcion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("producto_descripcion");
            entity.Property(e => e.ProductoNombre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("producto_nombre");
            entity.Property(e => e.ProductoPrecio)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("producto_precio");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
