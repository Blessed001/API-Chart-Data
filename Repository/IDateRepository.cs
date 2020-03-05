using System.Collections.Generic;
using TestTask.Models;

namespace TestTask.Repository
{
    public interface IDateRepository
    {
        IEnumerable<Dataa> GetDates { get; }
        Dataa GetDateById(int dateId);
    }
}
