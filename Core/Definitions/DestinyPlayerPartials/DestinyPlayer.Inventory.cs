using DestinyMod.Content.Elements;
using DestinyMod.Content.Rarities;

namespace DestinyMod.Core.Definitions.DestinyPlayerPartials
{
    public partial class DestinyPlayer
    {
        public const string InventoryTextureDir = "DestinyMod/Assets/textures/ui/inventory/";

        //entry 0 is always the EQUIPPED item. 

        public List<Armor> headArmorInventory;

        public List<Armor> armArmorInventory;

        public List<Armor> chestArmorInventory;

        public List<Armor> legArmorInventory;

        public List<Armor> classArmorInventory;

        public List<DestinyItem> postMasterSpace = new(45);

        public List<DestinyItem> vaultSpace = new(500);

        public List<Emblem> emblemSlot = new(10);

        public List<Ghost> ghostSlot = new(10);

        public List<Weapon> heavyWeapons;

        public List<Weapon> primaryWeapons;

        public List<Weapon> secondaryWeapons;

        internal bool ExoticArmorEquipped()
        {
            if (headArmorInventory[0].itemRarity is Exotic)
                return true;

            if (armArmorInventory[0].itemRarity is Exotic)
                return true;

            if (chestArmorInventory[0].itemRarity is Exotic)
                return true;

            if (legArmorInventory[0].itemRarity is Exotic)
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

        internal static void EquipItem(List<DestinyItem> listInQuestion, DestinyItem itemToEquip)
        {
            DestinyItem itemToSwapOut = listInQuestion.First();
            int indexOf = listInQuestion.IndexOf(itemToEquip);
            listInQuestion[0] = itemToEquip;
            listInQuestion[indexOf] = itemToSwapOut;
        }

        private void EnterArmor(Armor armor)
        {

        }

        internal void EnterItem(DestinyItem item)
        {
            if (item is Armor)
                EnterArmor((Armor)item);

            if (item is Weapon)
                EnterWeapon((Weapon)item);
        }

        private void EnterWeapon(Weapon weapon)
        {
            if (weapon.ammoType is Weapon.AmmoType.Heavy && !SendToPostmaster(heavyWeapons, weapon))
            {
                heavyWeapons[heavyWeapons.Count + 1] = weapon;
                OnAddItem(weapon);
            }

            if (weapon.weaponDamageType is Kinetic || weapon.weaponDamageType is Stasis && !SendToPostmaster(primaryWeapons, weapon))
            {
                primaryWeapons[primaryWeapons.Count + 1] = weapon;
                OnAddItem(weapon);
            } 

            else if (!SendToPostmaster(secondaryWeapons, weapon))
            {
                secondaryWeapons[secondaryWeapons.Count + 1] = weapon;
                OnAddItem(weapon);
            }
        }

        internal bool SendToPostmaster(IEnumerable<DestinyItem> listInQuestion, DestinyItem itemToSend)
        {
            if (listInQuestion.Count() == 10)
            {
                postMasterSpace.Add(itemToSend);
                OnSentToPostmaster(itemToSend);
                return true;
            }

            if (postMasterSpace.Count >= 45)
            {
                //leave on floor
                return false;
            }

            else return false;
        }

        public virtual void OnAddItem(DestinyItem item) { }

        public virtual void OnSentToPostmaster(DestinyItem item) { }
    }
}