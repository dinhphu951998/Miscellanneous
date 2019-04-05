using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MySqlNormalization.Models
{
    public partial class thanhtamluxuryContext : DbContext
    {
        public thanhtamluxuryContext()
        {
        }

        public thanhtamluxuryContext(DbContextOptions<thanhtamluxuryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<Header> Header { get; set; }
        public virtual DbSet<Imageitem> Imageitem { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Pricedetail> Pricedetail { get; set; }
        public virtual DbSet<Serviceitem> Serviceitem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=zaQ@1234;database=thanhtamluxury");
            base.OnConfiguring(optionsBuilder);

        }

    }
}
