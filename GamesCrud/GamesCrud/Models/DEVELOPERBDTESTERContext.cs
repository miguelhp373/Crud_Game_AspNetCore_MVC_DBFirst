using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GamesCrud.Models
{
    public partial class DEVELOPERBDTESTERContext : DbContext
    {
        public DEVELOPERBDTESTERContext()
        {
        }

        public DEVELOPERBDTESTERContext(DbContextOptions<DEVELOPERBDTESTERContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=DEVELOPERBDTESTER;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__GAMES__CC87E12775920A9F");

                entity.ToTable("GAMES");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.CodigoBarras)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_BARRAS");

                entity.Property(e => e.ConteudoEmbalagem)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CONTEUDO_EMBALAGEM");

                entity.Property(e => e.FaixaEtaria)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAIXA_ETARIA");

                entity.Property(e => e.Fornecedor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FORNECEDOR");

                entity.Property(e => e.Idiomas)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IDIOMAS");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MARCA");

                entity.Property(e => e.Plataforma)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PLATAFORMA");

                entity.Property(e => e.ReferenciaModelo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("REFERENCIA_MODELO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
