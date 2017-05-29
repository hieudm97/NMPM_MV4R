namespace PROJECT
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        public virtual DbSet<DIA> DIAs { get; set; }
        public virtual DbSet<DONHANG> DONHANGs { get; set; }
        public virtual DbSet<DONHANGCANXULY> DONHANGCANXULies { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIA>()
                .HasMany(e => e.CHITIETDONHANGs)
                .WithRequired(e => e.DIA)
                .HasForeignKey(e => e.DIA_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DONHANG>()
                .HasMany(e => e.CHITIETDONHANGs)
                .WithRequired(e => e.DONHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DONHANG>()
                .HasMany(e => e.DONHANGCANXULies)
                .WithRequired(e => e.DONHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.DONHANGs)
                .WithOptional(e => e.KHACHHANG)
                .HasForeignKey(e => e.KHACHHANG_ID);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.DONHANGs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.NHANVIEN_ID);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NHANVIEN1)
                .WithOptional(e => e.NHANVIEN2)
                .HasForeignKey(e => e.QUANLI_ID);
        }
    }
}
