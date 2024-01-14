using Microsoft.EntityFrameworkCore;
using Stock.Service.Models.Entities;

namespace Stock.Service.Models.Contexts
{
    public class StockDbContext : DbContext
    {
        public StockDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<OrderInbox> OrderInboxes { get; set; }
    }
}
