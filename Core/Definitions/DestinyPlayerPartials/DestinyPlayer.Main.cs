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

            headArmorInventory ??= new(10);
            armArmorInventory ??= new(10);
            chestArmorInventory ??= new(10);
            legArmorInventory ??= new(10);
            classArmorInventory ??= new(10);

            base.Load();
        }

        public override void LoadData(TagCompound tag)
        {
            Class = PlayerClassLoader.Get(tag.GetInt(nameof(Class)));
            selectedSubclass = PlayerSubclassLoader.Get(tag.GetInt(nameof(selectedSubclass)));

            experienceCurrent = tag.GetInt(nameof(experienceCurrent));
            experienceTotal = tag.GetInt(nameof(experienceTotal));
            playerLevel = tag.GetInt(nameof(playerLevel));

            vaultSpace = tag.Get<List<DestinyItem>>(nameof(vaultSpace));

            primaryWeapons = tag.Get<List<Weapon>>(nameof(primaryWeapons));
            secondaryWeapons = tag.Get<List<Weapon>>(nameof(secondaryWeapons));
            heavyWeapons = tag.Get<List<Weapon>>(nameof(heavyWeapons));

            headArmorInventory = tag.Get<List<Armor>>(nameof(headArmorInventory));
            armArmorInventory = tag.Get<List<Armor>>(nameof(armArmorInventory));
            chestArmorInventory = tag.Get<List<Armor>>(nameof(chestArmorInventory));
            legArmorInventory = tag.Get<List<Armor>>(nameof(legArmorInventory));
            classArmorInventory = tag.Get<List<Armor>>(nameof(classArmorInventory));

            base.LoadData(tag);
        }

        public override void SaveData(TagCompound tag)
        {
            tag[nameof(Class)] = Class.ID;
            tag[nameof(selectedSubclass)] = selectedSubclass.ID;

            tag[nameof(experienceCurrent)] = experienceCurrent;
            tag[nameof(experienceTotal)] = experienceTotal;
            tag[nameof(playerLevel)] = playerLevel;

            tag[nameof(vaultSpace)] = vaultSpace;

            tag[nameof(primaryWeapons)] = primaryWeapons;
            tag[nameof(secondaryWeapons)] = secondaryWeapons;
            tag[nameof(heavyWeapons)] = heavyWeapons;

            tag[nameof(headArmorInventory)] = headArmorInventory;
            tag[nameof(armArmorInventory)] = armArmorInventory;
            tag[nameof(chestArmorInventory)] = chestArmorInventory;
            tag[nameof(legArmorInventory)] = legArmorInventory;
            tag[nameof(classArmorInventory)] = classArmorInventory;

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