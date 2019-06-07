using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarteiraDeFundosAPI.Models
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions<StockContext> options) 
            : base(options)
        {

        }
        public DbSet<Stock> StockList { get; set; }
    }
}
