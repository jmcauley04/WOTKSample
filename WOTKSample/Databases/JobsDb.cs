using WOTKSample.Models;

namespace WOTKSample.Databases
{
    public static class JobsDb
    {
        public static List<Job> Jobs = new List<Job>()
        {
            new Job() { Name = Constants.Jobs.Dragoon, Abilities = new List<Ability>() {
                AbilitiesDb.Abilities.Single(x => x.Name == Constants.Abilities.Jump)
            } },

            new Job() { Name = Constants.Jobs.Magi, Abilities = new List<Ability>() {
                AbilitiesDb.Abilities.Single(x => x.Name == Constants.Abilities.FireI),
                AbilitiesDb.Abilities.Single(x => x.Name == Constants.Abilities.QuakeII),
                AbilitiesDb.Abilities.Single(x => x.Name == Constants.Abilities.LitIII)
            } },
        };
    }
}
