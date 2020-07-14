using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.DataAccess.Models
{
    public class Task1DbContext : DbContext
    {
        public Task1DbContext(DbContextOptions<Task1DbContext> options) : base(options)
        {
        }        

        public DbSet<Items> Items { get; set; }       
    }
}
