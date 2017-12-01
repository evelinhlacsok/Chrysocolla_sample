using GitProWorkshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitProWorkshop.Repositories
{
    public class WorkshopRepository
    {
        WorkshopContext WorkshopContext;

        public WorkshopRepository(WorkshopContext workshopContext)
        {
            WorkshopContext = workshopContext;
        }
    }
}
