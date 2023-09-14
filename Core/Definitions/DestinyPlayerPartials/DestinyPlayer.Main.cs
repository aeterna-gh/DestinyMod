namespace DestinyMod.Core.Definitions.DestinyPlayerPartials
{
    public partial class DestinyPlayer : ModPlayer
    {
        public PlayerClass Class { get; internal set; }

        public PlayerSubclass selectedSubclass;

        public int playerLevel;

        public int experienceCurrent;

        public override void ResetEffects()
        {
            statAgility = 0;
            statResilience = 0;
            statRecovery = 0;
            statDiscipline = 0;
            statIntellect = 0;
            statStrength = 0;

            lightLevel = 0;

            base.ResetEffects();
        }

        public override void Load()
        {

            base.Load();
        }

        public override void Unload()
        {
            primaryWeapons = null;
            secondaryWeapons = null;
            heavyWeapons = null;

            base.Unload();
        }
    }
}