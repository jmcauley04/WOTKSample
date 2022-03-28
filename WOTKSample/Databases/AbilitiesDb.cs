using WOTKSample.Models;

namespace WOTKSample.Databases
{
    public static class AbilitiesDb
    {
        public static List<Ability> Abilities = new List<Ability>()
        {
            new Ability() {Name = Constants.Abilities.Jump, Effect = "Air", Capacity = 3, Cost = 50, CostType = "AP" },
            new Ability() {Name = Constants.Abilities.FireI, Effect = "Fire", Capacity = 5, Cost = 25 },
            new Ability() {Name = Constants.Abilities.QuakeII, Effect = "Earth", Capacity = 2, Cost = 75 },
            new Ability() {Name = Constants.Abilities.LitIII, Effect = "Lightning", Capacity = 1, Cost = 150 },
        };
    }
}
