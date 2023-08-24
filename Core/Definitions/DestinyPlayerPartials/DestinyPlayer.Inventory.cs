namespace DestinyMod.Core.Definitions.DestinyPlayerPartials
{
    public partial class DestinyPlayer
    {
        public const string InventoryTextureDir = "DestinyMod/Assets/textures/ui/inventory/";

        //entry 0 is always the EQUIPPED item. 

        public List<Armor> headArmor;

        public List<Armor> armArmor;

        public List<Armor> chestArmor;

        public List<Armor> legArmor;

        public List<Armor> classArmor;

        public List<DestinyItem> postMasterSpace = new(45);

        public List<DestinyItem> vaultSpace = new(500);

        public List<Emblem> emblemSlot = new(10);

        public List<Ghost> ghostSlot = new(10);

        public List<Weapon> heavyWeapons;

        public List<Weapon> primaryWeapons;

        public List<Weapon> secondaryWeapons;

        internal bool ExoticArmorEquipped()
        {
            if (headArmor[0].itemRarity is Exotic)
                return true;

            if (armArmor[0].itemRarity is Exotic)
                return true;

            if (chestArmor[0].itemRarity is Exotic)
                return true;

            if (legArmor[0].itemRarity is Exotic)
                return true;

            else return false;
        }

        internal bool ExoticWeaponEquipped()
        {
            if (primaryWeapons[0].itemRarity is Exotic)
                return true;

            if (secondaryWeapons[0].itemRarity is Exotic)
                return true;

            if (heavyWeapons[0].itemRarity is Exotic)
                return true;

            else return false;
        }

        internal void EnterNewItem(DestinyItem item)
        {

        }

        private void EnterWeapon(Weapon weapon)
        {
            if (weapon.ammoType is Weapon.AmmoType.Heavy && !SendToPostmaster(heavyWeapons, weapon))
            {
                heavyWeapons[heavyWeapons.Count(x => x is Weapon)] = weapon;
                OnAddItem(weapon);
            }

            if (weapon.itemElement is not Kinetic || weapon.itemElement is not Stasis && !SendToPostmaster(secondaryWeapons.ToList<DestinyItem>(), weapon))
            {
                secondaryWeapons[secondaryWeapons.Count(x => x is Weapon)] = weapon;
                OnAddItem(weapon);
            }

            else if (!SendToPostmaster(primaryWeapons.ToList<DestinyItem>(), weapon))
            {
                primaryWeapons[primaryWeapons.Count(x => x is Weapon)] = weapon;
                OnAddItem(weapon);
            }
        }

        internal bool SendToPostmaster(IEnumerable<DestinyItem> listToTest, DestinyItem itemInQuestion)
        {
            if (listToTest.Count() >= 10)
            {
                postMasterSpace.Add(itemInQuestion);
                return true;
            }

            else return false;
        }

        public virtual void OnAddItem(DestinyItem item) { }
    }
}