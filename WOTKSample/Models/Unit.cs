#nullable disable

namespace WOTKSample.Models
{
    public class Unit
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
