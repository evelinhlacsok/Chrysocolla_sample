using GitProWorkshop.Entities;
using GitProWorkshop.Models;
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

        public void AddSomething()
        {
            var data = new Praise()
            {
                firstAdjective = "nagyon",
                secondAdjective = "szép",
                multiply = 3
            };
            WorkshopContext.Add(data);
        }
    }
}
