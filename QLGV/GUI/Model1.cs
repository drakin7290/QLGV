namespace GUI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=QLGVModelDB")
        {
        }

        public virtual DbSet<GIAOVIEN> GIAOVIENs { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }
        public virtual DbSet<THOIKHOABIEU> THOIKHOABIEUx { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.sodienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.id_monhoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.THOIKHOABIEUx)
                .WithOptional(e => e.GIAOVIEN)
                .HasForeignKey(e => e.id_giaovien);

            modelBuilder.Entity<MONHOC>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.GIAOVIENs)
                .WithOptional(e => e.MONHOC)
                .HasForeignKey(e => e.id_monhoc);

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.THOIKHOABIEUx)
                .WithOptional(e => e.MONHOC)
                .HasForeignKey(e => e.id_monhoc);

            modelBuilder.Entity<THOIKHOABIEU>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THOIKHOABIEU>()
                .Property(e => e.id_giaovien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THOIKHOABIEU>()
                .Property(e => e.id_monhoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THOIKHOABIEU>()
                .Property(e => e.ten_lop)
                .IsUnicode(false);
        }
    }
}
