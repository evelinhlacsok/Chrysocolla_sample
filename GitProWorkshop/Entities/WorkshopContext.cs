using GitProWorkshop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitProWorkshop.Entities
{
    public class WorkshopContext : DbContext
    {
        public DbSet<Praise> Praises;

        public WorkshopContext(DbContextOptions<WorkshopContext> options) : base(options)
        {
        }
    }
}
