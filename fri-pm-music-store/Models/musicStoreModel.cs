namespace fri_pm_music_store.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class musicStoreModel : DbContext
    {
        public musicStoreModel()
            : base("name=musicStoreModel")
        {
        }

        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.start_ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.end_ip_address)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<fri_pm_music_store.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<fri_pm_music_store.Models.Artist> Artists { get; set; }

        public System.Data.Entity.DbSet<fri_pm_music_store.Models.Genre> Genres { get; set; }
    }
}
