using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanbaneManager.Shared.Entities
{
    public class Order : IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public int ExecutorId { get; set; }
        [ForeignKey("ExecutorId")]
        public Employee Executor { get; set; }
        public int? CarId { get; set; }
        [ForeignKey("CarId")]
        public Car Car { get; set; }
        public int? TradePointId { get; set; }
        [ForeignKey("TradePointId")]
        public TradePoint TradePoint { get; set; }
        public string OrderDescription { get; set; }
    }
}