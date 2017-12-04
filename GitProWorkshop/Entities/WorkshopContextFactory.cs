using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitProWorkshop.Entities
{
    public class WorkshopContextFactory : IDesignTimeDbContextFactory<WorkshopContext>
    {
        public WorkshopContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WorkshopContext>();
            optionsBuilder.UseSqlite("Data Source=workshop.db");

            return new WorkshopContext(optionsBuilder.Options);
        }
    }
}
