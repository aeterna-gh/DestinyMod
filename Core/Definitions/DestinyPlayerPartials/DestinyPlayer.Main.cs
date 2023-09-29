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
            ResetStats();

            base.ResetEffects();
        }

        public override void Load()
        {
            On_Player.Hurt_PlayerDeathReason_int_int_bool_bool_int_bool_float_float_float += HurtDetour;

            vaultSpace ??= new(500);

            primaryWeapons ??= new(10);
            secondaryWeapons ??= new(10);
            heavyWeapons ??= new(10);

            base.Load();
        }

        public override void LoadData(TagCompound tag)
        {
            //class choice saving
            //subclass choice saving

            tag[nameof(experienceCurrent)] = experienceCurrent;

            tag[nameof(playerLevel)] = playerLevel;

            tag["vaultSpace"] = vaultSpace.Select(x => x).ToList();

            tag["primaryWeapons"] = primaryWeapons.Select(x => x).ToList();
            tag["secondaryWeapons"] = secondaryWeapons.Select(x => x).ToList();
            tag["heavyWeapons"] = heavyWeapons.Select(x => x).ToList();

            base.LoadData(tag);
        }

        public override void SaveData(TagCompound tag)
        {
            //class choice saving
            //subclass choice saving

            playerLevel = tag.Get<int>(nameof(playerLevel));

            vaultSpace = tag.Get<List<DestinyItem>>("vaultSpace").Select(x => x).ToList();

            primaryWeapons = tag.Get<List<Weapon>>("primaryWeapons").Select(x => x).ToList();
            secondaryWeapons = tag.Get<List<Weapon>>("secondaryWeapons").Select(x => x).ToList();
            heavyWeapons = tag.Get<List<Weapon>>("heavyWeapons").Select (x => x).ToList();

            base.SaveData(tag);
        }

        public override void Unload()
        {
            vaultSpace = null;

            primaryWeapons = null;
            secondaryWeapons = null;
            heavyWeapons = null;

            headArmorInventory = null;
            armArmorInventory = null;
            chestArmorInventory = null;
            legArmorInventory = null;
            classArmorInventory = null;

            base.Unload();
        }
    }
}