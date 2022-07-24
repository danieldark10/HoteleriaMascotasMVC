using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HoteleriaMascotas.Models.DB
{
    public partial class HoteleriaMascotasContext : DbContext
    {
        public HoteleriaMascotasContext()
        {
        }

        public HoteleriaMascotasContext(DbContextOptions<HoteleriaMascotasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administracionsolicitud> Administracionsolicituds { get; set; } = null!;
        public virtual DbSet<Agendabano> Agendabanos { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Habitacion> Habitacions { get; set; } = null!;
        public virtual DbSet<Mascotum> Mascota { get; set; } = null!;
        public virtual DbSet<Pagoss> Pagosses { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
       
        public virtual DbSet<Reserva> Reservas { get; set; } = null!;
       
        public virtual DbSet<Rol> Rols { get; set; } = null!;
        public virtual DbSet<Solicitud> Solicituds { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<Tipodesolicitud> Tipodesolicituds { get; set; } = null!;
        public virtual DbSet<Trabajador> Trabajadors { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost; Database=HoteleriaMascotas; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administracionsolicitud>(entity =>
            {
                entity.HasKey(e => e.Idadministacionsolicitud)
                    .IsClustered(false);

                entity.ToTable("ADMINISTRACIONSOLICITUD");

                entity.HasIndex(e => e.Idtrabajador, "ADMINISTRA_FK");

                entity.HasIndex(e => e.Idsolicitud, "TIENEADMINISTRACION_FK");

                entity.Property(e => e.Idadministacionsolicitud).HasColumnName("IDADMINISTACIONSOLICITUD");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.Idsolicitud).HasColumnName("IDSOLICITUD");

                entity.Property(e => e.Idtrabajador).HasColumnName("IDTRABAJADOR");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACIONES")
                    .IsFixedLength();

                entity.Property(e => e.Respuesta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RESPUESTA")
                    .IsFixedLength();

                entity.HasOne(d => d.IdsolicitudNavigation)
                    .WithMany(p => p.Administracionsolicituds)
                    .HasForeignKey(d => d.Idsolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMINIST_TIENEADMI_SOLICITU");

                entity.HasOne(d => d.IdtrabajadorNavigation)
                    .WithMany(p => p.Administracionsolicituds)
                    .HasForeignKey(d => d.Idtrabajador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMINIST_ADMINISTR_TRABAJAD");
            });

            modelBuilder.Entity<Agendabano>(entity =>
            {
                entity.HasKey(e => e.Idagendabanos)
                    .IsClustered(false);

                entity.ToTable("AGENDABANOS");

                entity.HasIndex(e => e.Idtrabajador, "REALIZABANO_FK");

                entity.HasIndex(e => e.Idsolicitud, "TIENEAGENDABANOS_FK");

                entity.Property(e => e.Idagendabanos).HasColumnName("IDAGENDABANOS");

                entity.Property(e => e.Fechabano)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHABANO");

                entity.Property(e => e.Horariobanoinicio)
                    .HasColumnType("datetime")
                    .HasColumnName("HORARIOBANOINICIO");

                entity.Property(e => e.Horariobanotermino)
                    .HasColumnType("datetime")
                    .HasColumnName("HORARIOBANOTERMINO");

                entity.Property(e => e.Idsolicitud).HasColumnName("IDSOLICITUD");

                entity.Property(e => e.Idtrabajador).HasColumnName("IDTRABAJADOR");

                entity.Property(e => e.Precioporbano)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRECIOPORBANO");

                entity.HasOne(d => d.IdsolicitudNavigation)
                    .WithMany(p => p.Agendabanos)
                    .HasForeignKey(d => d.Idsolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENDABA_TIENEAGEN_SOLICITU");

                entity.HasOne(d => d.IdtrabajadorNavigation)
                    .WithMany(p => p.Agendabanos)
                    .HasForeignKey(d => d.Idtrabajador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENDABA_REALIZABA_TRABAJAD");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Idcliente)
                    .IsClustered(false);

                entity.ToTable("CLIENTE");

                entity.HasIndex(e => e.Idrol, "CLIENTETIENE_FK");

                entity.HasIndex(e => e.Idpersona, "ISADOS_FK");

                entity.Property(e => e.Idcliente).HasColumnName("IDCLIENTE");

                entity.Property(e => e.Idpersona).HasColumnName("IDPERSONA");

                entity.Property(e => e.Idrol).HasColumnName("IDROL");

                entity.Property(e => e.Numeropagos).HasColumnName("NUMEROPAGOS");

                entity.HasOne(d => d.IdpersonaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.Idpersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENTE_ISADOS_PERSONA");

                entity.HasOne(d => d.IdrolNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.Idrol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENTE_CLIENTETI_ROL");
            });

            modelBuilder.Entity<Habitacion>(entity =>
            {
                entity.HasKey(e => e.Idhabitacion)
                    .IsClustered(false);

                entity.ToTable("HABITACION");

                entity.Property(e => e.Idhabitacion).HasColumnName("IDHABITACION");

                entity.Property(e => e.Caracteristicas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARACTERISTICAS")
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .IsFixedLength();

                entity.Property(e => e.Numerohabitacion)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("NUMEROHABITACION")
                    .IsFixedLength();

                entity.Property(e => e.Preciohora)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("PRECIOHORA");

                entity.Property(e => e.Tipohabitacion)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TIPOHABITACION")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mascotum>(entity =>
            {
                entity.HasKey(e => e.Idmascota)
                    .IsClustered(false);

                entity.ToTable("MASCOTA");

                entity.HasIndex(e => e.Idcliente, "TIENEMASCOTA_FK");

                entity.Property(e => e.Idmascota).HasColumnName("IDMASCOTA");

                entity.Property(e => e.Chip).HasColumnName("CHIP");

                entity.Property(e => e.Edad).HasColumnName("EDAD");

                entity.Property(e => e.Idcliente).HasColumnName("IDCLIENTE");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .IsFixedLength();

                entity.Property(e => e.Personalidad)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PERSONALIDAD")
                    .IsFixedLength();

                entity.Property(e => e.Raza)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RAZA")
                    .IsFixedLength();

                entity.Property(e => e.Tipoanimal)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TIPOANIMAL")
                    .IsFixedLength();

                entity.HasOne(d => d.IdclienteNavigation)
                    .WithMany(p => p.Mascota)
                    .HasForeignKey(d => d.Idcliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASCOTA_TIENEMASC_CLIENTE");
            });

            modelBuilder.Entity<Pagoss>(entity =>
            {
                entity.HasKey(e => e.Idpago)
                    .IsClustered(false);

                entity.ToTable("PAGOSS");

                entity.HasIndex(e => e.Idadministacionsolicitud, "GENERA_FK");

                entity.Property(e => e.Idpago).HasColumnName("IDPAGO");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.Fechaemision)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAEMISION");

                entity.Property(e => e.Fechapago)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAPAGO");

                entity.Property(e => e.Idadministacionsolicitud).HasColumnName("IDADMINISTACIONSOLICITUD");

                entity.Property(e => e.Montopago)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("MONTOPAGO");

                entity.Property(e => e.Numerocomprobante)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("NUMEROCOMPROBANTE")
                    .IsFixedLength();

                entity.HasOne(d => d.IdadministacionsolicitudNavigation)
                    .WithMany(p => p.Pagosses)
                    .HasForeignKey(d => d.Idadministacionsolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGOSS_GENERA_ADMINIST");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Idpersona)
                    .IsClustered(false);

                entity.ToTable("PERSONA");

                entity.Property(e => e.Idpersona).HasColumnName("IDPERSONA");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDO")
                    .IsFixedLength();

                entity.Property(e => e.Direccion)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION")
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .IsFixedLength();

                entity.Property(e => e.Rut)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RUT")
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SEXO")
                    .IsFixedLength();

                entity.Property(e => e.Telefono).HasColumnName("TELEFONO");
            });

          

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.Idreserva)
                    .IsClustered(false);

                entity.ToTable("RESERVA");

                entity.HasIndex(e => e.Idhabitacion, "TIENEHABITACION_FK");

                entity.HasIndex(e => e.Idsolicitud, "TIENERESERVA_FK");

                entity.Property(e => e.Idreserva).HasColumnName("IDRESERVA");

                entity.Property(e => e.Estado)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .IsFixedLength();

                entity.Property(e => e.Fechaentrada)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAENTRADA");

                entity.Property(e => e.Fechareserva)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHARESERVA");

                entity.Property(e => e.Fechasalida)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASALIDA");

                entity.Property(e => e.Horarioentrada)
                    .HasColumnType("datetime")
                    .HasColumnName("HORARIOENTRADA");

                entity.Property(e => e.Horariosalida)
                    .HasColumnType("datetime")
                    .HasColumnName("HORARIOSALIDA");

                entity.Property(e => e.Idhabitacion).HasColumnName("IDHABITACION");

                entity.Property(e => e.Idsolicitud).HasColumnName("IDSOLICITUD");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRECIO");

                entity.HasOne(d => d.IdhabitacionNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.Idhabitacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESERVA_TIENEHABI_HABITACI");

                entity.HasOne(d => d.IdsolicitudNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.Idsolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESERVA_TIENERESE_SOLICITU");
            });

           

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.Idrol)
                    .IsClustered(false);

                entity.ToTable("ROL");

                entity.Property(e => e.Idrol).HasColumnName("IDROL");

                entity.Property(e => e.Nombrerol)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NOMBREROL")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Solicitud>(entity =>
            {
                entity.HasKey(e => e.Idsolicitud)
                    .IsClustered(false);

                entity.ToTable("SOLICITUD");

                entity.HasIndex(e => e.Idtipodesolicitud, "DETERMINASOLICITUD_FK");

                entity.HasIndex(e => e.Idmascota, "ESTAEN_FK");

                entity.HasIndex(e => e.Idcliente, "PIDE_FK");

                entity.Property(e => e.Idsolicitud).HasColumnName("IDSOLICITUD");

                entity.Property(e => e.Descripcionsolicitud)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCIONSOLICITUD")
                    .IsFixedLength();

                entity.Property(e => e.Idcliente).HasColumnName("IDCLIENTE");

                entity.Property(e => e.Idmascota).HasColumnName("IDMASCOTA");

                entity.Property(e => e.Idtipodesolicitud).HasColumnName("IDTIPODESOLICITUD");

                entity.HasOne(d => d.IdclienteNavigation)
                    .WithMany(p => p.Solicituds)
                    .HasForeignKey(d => d.Idcliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SOLICITU_PIDE_CLIENTE");

                entity.HasOne(d => d.IdmascotaNavigation)
                    .WithMany(p => p.Solicituds)
                    .HasForeignKey(d => d.Idmascota)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SOLICITU_ESTAEN_MASCOTA");

                entity.HasOne(d => d.IdtipodesolicitudNavigation)
                    .WithMany(p => p.Solicituds)
                    .HasForeignKey(d => d.Idtipodesolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SOLICITU_DETERMINA_TIPODESO");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.Idstatus)
                    .IsClustered(false);

                entity.ToTable("STATUS");

                entity.HasIndex(e => e.Idmascota, "TIENESTATUS_FK");

                entity.Property(e => e.Idstatus).HasColumnName("IDSTATUS");

                entity.Property(e => e.Idmascota).HasColumnName("IDMASCOTA");

                entity.Property(e => e.Nombrestatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRESTATUS")
                    .IsFixedLength();

                entity.HasOne(d => d.IdmascotaNavigation)
                    .WithMany(p => p.Statuses)
                    .HasForeignKey(d => d.Idmascota)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STATUS_TIENESTAT_MASCOTA");
            });

            modelBuilder.Entity<Tipodesolicitud>(entity =>
            {
                entity.HasKey(e => e.Idtipodesolicitud)
                    .IsClustered(false);

                entity.ToTable("TIPODESOLICITUD");

                entity.Property(e => e.Idtipodesolicitud).HasColumnName("IDTIPODESOLICITUD");

                entity.Property(e => e.Nombresolicitud)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRESOLICITUD")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Trabajador>(entity =>
            {
                entity.HasKey(e => e.Idtrabajador)
                    .IsClustered(false);

                entity.ToTable("TRABAJADOR");

                entity.HasIndex(e => e.Idpersona, "ISAUNO_FK");

                entity.HasIndex(e => e.Idrol, "TRABAJADORTIENE_FK");

                entity.Property(e => e.Idtrabajador).HasColumnName("IDTRABAJADOR");

                entity.Property(e => e.Area)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AREA")
                    .IsFixedLength();

                entity.Property(e => e.Fechaingreso)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAINGRESO");

                entity.Property(e => e.Idpersona).HasColumnName("IDPERSONA");

                entity.Property(e => e.Idrol).HasColumnName("IDROL");

                entity.HasOne(d => d.IdpersonaNavigation)
                    .WithMany(p => p.Trabajadors)
                    .HasForeignKey(d => d.Idpersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRABAJAD_ISAUNO_PERSONA");

                entity.HasOne(d => d.IdrolNavigation)
                    .WithMany(p => p.Trabajadors)
                    .HasForeignKey(d => d.Idrol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRABAJAD_TRABAJADO_ROL");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .IsClustered(false);

                entity.ToTable("USUARIO");

                entity.HasIndex(e => e.Idrol, "DETERMINA_FK");

                entity.Property(e => e.Idusuario).HasColumnName("IDUSUARIO");

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CONTRASENA")
                    .IsFixedLength();

                entity.Property(e => e.Idrol).HasColumnName("IDROL");

                entity.Property(e => e.Nombreusuario)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NOMBREUSUARIO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdrolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Idrol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIO_DETERMINA_ROL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
