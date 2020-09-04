using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class DelegationContext : DbContext
    {
        public DbSet<DelegationItem> DelegationItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-5KOF6PB\SQLEXPRESS;Initial Catalog=DelegationApp;Integrated Security=True");
        }
    }
}
