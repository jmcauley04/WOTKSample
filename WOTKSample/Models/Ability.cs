#nullable disable

namespace WOTKSample.Models
{
    public class Ability
    {
        public string Name { get; set; }
        public string Effect { get; set; }
        public int Capacity { get; set; }
        public int Cost { get; set; }
        public string CostType { get; set; } = "MP";
    }

    public enum CostType
    {
        MP,
        AP,
        
    }
}
