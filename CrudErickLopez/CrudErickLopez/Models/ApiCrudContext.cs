using Microsoft.EntityFrameworkCore;

namespace CrudErickLopez.Models
{
    public partial class ApiCrudContext : DbContext
    {
        public ApiCrudContext()
        {

        }

        public ApiCrudContext(DbContextOptions<ApiCrudContext> options) : base(options)
        {

        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Nro_documento)
                .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nro_documento");

                entity.Property(e => e.Email)
                .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fecha_nacimiento)
                    .IsUnicode(false)
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
