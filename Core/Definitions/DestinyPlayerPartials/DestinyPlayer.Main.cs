namespace DestinyMod.Core.Definitions.DestinyPlayerPartials
{
    public partial class DestinyPlayer : ModPlayer
    {
        public int experienceCurrent;

        public int experienceLevelCap;

        public int experienceTotal;

        public int playerLevel;

        public PlayerClass Class { get; internal set; }

        public PlayerSubclass selectedSubclass;

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
            vaultSpace ??= new(500);

            primaryWeapons ??= new(10);
            secondaryWeapons ??= new(10);
            heavyWeapons ??= new(10);

            base.Load();
        }

        public override void LoadData(TagCompound tag)
        {
            tag["primaryWeapons"] = primaryWeapons.Select(x => x).ToList();
            tag["secondaryWeapons"] = secondaryWeapons.Select(x => x).ToList();
            tag["heavyWeapons"] = heavyWeapons.Select(x => x).ToList();

            base.LoadData(tag);
        }

        public override void SaveData(TagCompound tag)
        {
            primaryWeapons = tag.Get<List<Weapon>>("primaryWeapons").Select(x => x).ToList();
            secondaryWeapons = tag.Get<List<Weapon>>("secondaryWeapons").Select(x => x).ToList();
            heavyWeapons = tag.Get<List<Weapon>>("heavyWeapons").Select (x => x).ToList();

            base.SaveData(tag);
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