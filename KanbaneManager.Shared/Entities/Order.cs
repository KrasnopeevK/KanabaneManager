using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanbaneManager.Shared.Entities
{
    public class Order : IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        [ForeignKey("ExecutorId")]
        public int ExecutorId { get; set; }
        public Employee Executor { get; set; }
        [ForeignKey("CarId")]
        public int? CarId { get; set; }
        public Car Car { get; set; }
        [ForeignKey("TradePointId")]
        public int? TradePointId { get; set; }
        public TradePoint TradePoint { get; set; }
        
        [DefaultValue(1)]
        [ForeignKey("StateId")]
        public int StateId { get; set; }
        public State State { get; set; }
        public string OrderDescription { get; set; }
    }
}