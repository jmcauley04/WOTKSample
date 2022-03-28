using WOTKSample.Models;

namespace WOTKSample.Databases
{
    public static class UnitsDb
    {
        public static List<Unit> Units = new List<Unit>()
        {
            new Unit() { Name = Constants.Units.Kain, Hp = 500, Mp = 200, Jobs = new List<Job>{
                JobsDb.Jobs.Single(x => x.Name == Constants.Jobs.Dragoon )
            } },

            new Unit() { Name = Constants.Units.Ridia, Hp = 500, Mp = 200, Jobs = new List<Job>{
                JobsDb.Jobs.Single(x => x.Name == Constants.Jobs.Magi )
            } },

            new Unit() { Name = Constants.Units.RedMage, Hp = 500, Mp = 200, Jobs = new List<Job>{
                JobsDb.Jobs.Single(x => x.Name == Constants.Jobs.Dragoon ),
                JobsDb.Jobs.Single(x => x.Name == Constants.Jobs.Magi )
            } }
        };
    }
}
