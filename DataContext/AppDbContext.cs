using BlazorReportingTools.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorReportingTools.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<SupplierModel> Suppliers { get; set; }
        public DbSet<ItemModel> Items { get; set; }
        public DbSet<BudgetYearModel> BudgetYears { get; set; }
        public DbSet<PRItemSelectModel> PRItemSelectModels { get; set; }
        public DbSet<ItemcodeQtyPriceModel> ItemcodeQtyPriceModels { get; set; }
    }
}
