using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestTask.Models;
using TestTask.Repository;

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataasController : ControllerBase
    {
        private readonly IDateRepository _dateRepository;

        public DataasController(IDateRepository dateRepository)
        {
            _dateRepository = dateRepository;
        }

        //Get all dates
        [HttpGet]
        public IEnumerable<Dataa> Dates() 
        {
            var dates = _dateRepository.GetDates;

            return dates;
        }

        //Get date by Id
        [HttpGet("{id}")]
        public ActionResult<Dataa>Date(int id)
        {
            var date =  _dateRepository.GetDateById(id);

            if (date == null)
            {
                return NotFound();
            }

            return date;
        }
    }
}
