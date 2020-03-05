using System;
using System.ComponentModel.DataAnnotations;

namespace TestTask.Models
{
    public class Circle1
    {
        [Key]
        public int Circle1Id { get; set; }
        public int value { get; set; }
        public int maxValue { get; set; }
        public int DataId { get; set; }
        public Dataa Data { get; set; }
    }
}
