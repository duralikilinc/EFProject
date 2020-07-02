using System.Data.Entity;
using EFProject.Entities.Concrete;

namespace EFProject.DataAccess.Concrete.EntityFramework
{
    public class HastaneContext : DbContext
    {
        public HastaneContext() : base("name=HastaneContext")
        {
        }

        public virtual DbSet<HastaKarti> HastaKarti { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciRole> KullaniciRole { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Tani> Tani { get; set; }
        public virtual DbSet<Urun> Uruns{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HastaKarti>()
                .Property(e => e.TCNo)
                .IsUnicode(false);

            modelBuilder.Entity<HastaKarti>()
                .Property(e => e.Ad_Soyad)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleAd)
                .IsUnicode(false);

            modelBuilder.Entity<Tani>()
                .Property(e => e.TaniAdi)
                .IsUnicode(false);
        }
    }
}
