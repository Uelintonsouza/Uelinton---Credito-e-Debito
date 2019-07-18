using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UelintonBank.Domain.Entities;
using UelintonBankAPI.Domain.Entities;

namespace UelintonBank.Infra.Data.Context
{
    public class UelintonBankContext : DbContext
    {
        public DbSet<Lancamentos> Lancamentos { get; set; }
        public DbSet<Account> Account { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=FAMILIA;Database=MicroservicesUelinton;Trusted_Connection=True;User ID=sa;Password=familia@2018");
        }

        public UelintonBankContext(DbContextOptions<UelintonBankContext> contextOptions) : base(contextOptions)
        {

        }

        public UelintonBankContext()
        {

        }
    }
}
