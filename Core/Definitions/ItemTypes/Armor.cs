namespace DestinyMod.Core.Definitions.ItemTypes
{
    public abstract class Armor : DestinyItem
    {
        public int[] armorStats;
        
        public int[] rolledStats;

        public virtual void SetDefaultStats()
        {
            armorStats[0] = 0;
            armorStats[1] = 0;
            armorStats[2] = 0;
            armorStats[3] = 0;
            armorStats[4] = 0;
            armorStats[5] = 0;
        }

        public virtual void UpdateArmor(Armor armor)
        {
            armor.armorStats[0] += armor.rolledStats[0];
            armor.armorStats[1] += armor.rolledStats[1];
            armor.armorStats[2] += armor.rolledStats[2];
            armor.armorStats[3] += armor.rolledStats[3];
            armor.armorStats[4] += armor.rolledStats[4];
            armor.armorStats[5] += armor.rolledStats[5];
        }

        public override void OnCreated(ItemCreationContext context)
        {
            armorStats ??= new int[6];

            rolledStats ??= new int[6];
            
            if (rarity is ItemRarity.Legendary)
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

            //Exotics with focusing handled separately and in their own file.

            base.OnCreated(context);
        }

        public override void UpdateEquip(Player player)
        {
            UpdateArmor(this);

            //update based on equipped mods too.

            base.UpdateEquip(player);
        }
    }
}