using Market_otomasyon.Moduls.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_otomasyon.Context
{
    public class MarketDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=ACER-NITRO\SQLEXPRESS;database=MarketProje;trusted_connection=true;");
        }
        public DbSet<Borc> Borcs { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Satici> Satıcıs { get; set; }

        public DbSet<PesinSatis> PesinSatis { get; set; }
        public DbSet<Satis> Satis { get; set; }
        public DbSet<Stok> Stoks  { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
        public DbSet<TedarikciBorc> TedarikciBorcs { get; set; }
        public DbSet<VeresiyeSatis> VeresiyeSatis { get; set; }





    }
}
