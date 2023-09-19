namespace DestinyMod.Core.Definitions.DestinyPlayerPartials
{
    public partial class DestinyPlayer
    {
        public int lightLevel;

        public int statAgility;

        public int statResilience;

        public int statRecovery;

        public int statDiscipline;

        public int statIntellect;

        public int statStrength;

        public void ResetStats()
        {
            lightLevel = 0;

            statAgility = 0;
            statResilience = 0;
            statRecovery = 0;
            statDiscipline = 0;
            statIntellect = 0;
            statStrength = 0;
        }

        public static int StatToLevel(int statInQuestion)
        {
            int resultLevel = (int)Math.Floor((double)(statInQuestion / 10)); //9.9 still equals 9!!!
            return resultLevel;
        }


    }
}