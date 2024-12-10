using Microsoft.EntityFrameworkCore;


public partial class ipgaContext : DbContext
{
    public ipgaContext()
    {
    }

    public ipgaContext(DbContextOptions<ipgaContext> options)
        : base(options)
    {
    }


    public virtual DbSet<tb_cargos> tb_cargos { get; set; }

    public virtual DbSet<tb_despesas> tb_despesas { get; set; }

    public virtual DbSet<tb_dizimos> tb_dizimos { get; set; }

    public virtual DbSet<tb_eventos> tb_eventos { get; set; }

    public virtual DbSet<tb_membros> tb_membros { get; set; }

    public virtual DbSet<tb_ministerios> tb_ministerios { get; set; }

    public virtual DbSet<tb_nivel_acesso> tb_nivel_acesso { get; set; }

    public virtual DbSet<tb_ofertas> tb_ofertas { get; set; }

    public virtual DbSet<tb_usuarios> tb_usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=RAFAEL\\SQLEXPRESS;Initial Catalog=IpgaDB;User ID=sa;Password=9173rafa");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tb_dizimos>(entity =>
        {
            entity.HasOne(d => d.diz_fk_mem).WithMany(p => p.tb_dizimos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_dizimos_tb_membros");
        });

        modelBuilder.Entity<tb_membros>(entity =>
        {
            entity.HasOne(d => d.mem_fk_car).WithMany(p => p.tb_membros).HasConstraintName("FK_tb_membros_tb_cargos");

            entity.HasOne(d => d.mem_fk_min).WithMany(p => p.tb_membros).HasConstraintName("FK_tb_membros_tb_ministerios");
        });

        modelBuilder.Entity<tb_usuarios>(entity =>
        {
            entity.HasOne(d => d.uso_fk_niv).WithMany(p => p.tb_usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_usuarios_tb_nivel_acesso");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}