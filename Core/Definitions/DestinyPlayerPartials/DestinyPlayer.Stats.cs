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

        public static int StatToLevel(int statInQuestion)
        {
            int resultLevel = (int)Math.Floor((double)(statInQuestion / 10)); //9.9 still equals 9!!!
            return resultLevel;
        }


    }
}