using DestinyMod.Content.Rarities;

namespace DestinyMod.Core.Definitions.ItemTypes
{
    public abstract class Armor : DestinyItem
    {
        public Element armorElement;

        public int lightLevel;

        public int[] armorStats;
        
        public int[] rolledStats;

        public Modification SlotA;

        public Modification SlotB;

        public Modification SlotC;

        public Modification SlotD;

        internal void ResetStats() 
        {
            armorStats[0] = 0;
            armorStats[1] = 0;
            armorStats[2] = 0;
            armorStats[3] = 0;
            armorStats[4] = 0;
            armorStats[5] = 0;
        }

        internal void UpdateEquippedMods(Armor armor)
        {

        }

        internal void UpdateRolledStats(Armor armor)
        {
            UpdateArmor(armor);

            armorStats[0] += rolledStats[0];
            armorStats[1] += rolledStats[1];
            armorStats[2] += rolledStats[2];
            armorStats[3] += rolledStats[3];
            armorStats[4] += rolledStats[4];
            armorStats[5] += rolledStats[5];
        }

        public virtual void SetDefaultStats()
        {
            armorStats[0] = 0;
            armorStats[1] = 0;
            armorStats[2] = 0;
            armorStats[3] = 0;
            armorStats[4] = 0;
            armorStats[5] = 0;
        }

        public virtual void UpdateArmor(Armor armor) { }

        public override void OnCreated(ItemCreationContext context)
        {
            armorStats ??= new int[6];

            rolledStats ??= new int[6];
            
            if (itemRarity is Legendary)
            {
                for (int i = 0; i < 2; i++)
                {
                    int rand = Main.rand.Next(1, StatRoll.statSubGroupA.Count + 1);
                    rolledStats[0] += StatRoll.statSubGroupA[rand].mob;
                    rolledStats[1] += StatRoll.statSubGroupA[rand].res;
                    rolledStats[2] += StatRoll.statSubGroupA[rand].rec;
                }

                for (int i = 0; i < 2; i++)
                {
                    int rand = Main.rand.Next(1, StatRoll.statSubGroupB.Count + 1);
                    rolledStats[3] += StatRoll.statSubGroupB[rand].dis;
                    rolledStats[4] += StatRoll.statSubGroupB[rand].intel;
                    rolledStats[5] += StatRoll.statSubGroupB[rand].str;
                }
            }

            //Exotics with focusing

            base.OnCreated(context);
        }

        public override void UpdateEquip(Player player)
        {
            ResetStats();
            UpdateRolledStats(this);

            //update based on equipped mods too.

            base.UpdateEquip(player);
        }
    }
}