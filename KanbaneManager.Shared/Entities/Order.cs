using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanbaneManager.Shared.Entities
{
    public class Order : IIdentifier
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime OrderDate { get; set; }
        public int ExecutorId { get; set; }
        [ForeignKey("ExecutorId")]
        public Employee Executor { get; set; }
        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public Car Car { get; set; }
        public string OrderDescription { get; set; }
    }
}