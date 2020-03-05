using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestTask.Models
{
    public class Dataa
    {
        [Key]
        public int DataId { get; set; }
        public int Year { get; set; }
        public Circle1 Circle1 { get; set; }
        public Circle2 Circle2 { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
