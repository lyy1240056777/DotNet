using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace FinalPractice.Models
{
    public class OrderContext:DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
