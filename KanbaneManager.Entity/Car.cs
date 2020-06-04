using System;
namespace KanbaneManager.Entity
{
    public class Car : IIdentifier
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string RegNumber { get; set; }
        public double WeightLift { get; set; }
        public DateTime LastToDate { get; set; }
        public DateTime NextToDate { get; set; }
    }
}