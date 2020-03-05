using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;

namespace TestTask.Repository
{
    public class DateRepository : IDateRepository
    {
        private readonly TestTaskContext _context;

        public DateRepository(TestTaskContext context)
        {
            _context = context;
        }

        public IEnumerable<Dataa> GetDates
        {

            get
            {

                return _context.Dates
                         .Include(d => d.Categories)
                         .Include(d => d.Circle1)
                         .Include(d => d.Circle2).ToList();

            }
        }

        public Dataa GetDateById(int dateId)
        {
            return _context.Dates.Where(d => d.DataId == dateId)
                         .Include(d => d.Categories)
                         .Include(d => d.Circle1)
                         .Include(d => d.Circle2).FirstOrDefault();
        }

    }
}
