using System;
using Microsoft.EntityFrameworkCore;

namespace CryptoGeniusWebApp.Models.Data
{
    public class CryptogramContext : DbContext
    {
        public CryptogramContext(DbContextOptions<CryptogramContext> options) : base(options)
        {
        }

        public DbSet<Cryptogram> Cryptogram { get; set; }
    }
}