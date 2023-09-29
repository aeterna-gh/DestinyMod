namespace DestinyMod.Core.Definitions.DestinyPlayerPartials
{
    public partial class DestinyPlayer
    {
        public bool isShieldBroken;

        public float resilDamageResist = 0f;

        public const int healthMax = 70;

        public const int shieldsBaseMax = 115;

        public int resilHealthAddition;

        public int healthTotalMax;

        public int healthCurrent;

        public int overShields;

        private double HurtDetour(On_Player.orig_Hurt_PlayerDeathReason_int_int_bool_bool_int_bool_float_float_float orig, Player self, PlayerDeathReason damageSource, int Damage, int hitDirection, bool pvp, bool quiet, int cooldownCounter, bool dodgeable, float armorPenetration, float scalingArmorPenetration, float knockback)
        {
            //base detouring

            //resillience damage resist calc

            //sheildbreak triggers

            return 0.0;
        }

        public void UpdateHealth()
        {
            healthTotalMax = healthMax + shieldsBaseMax + resilHealthAddition;

            if (healthCurrent <= healthMax)
                isShieldBroken = true;
        }

        public virtual void OnHit() { }

        public virtual void OnShieldBroken() { }

        public virtual void WhileShieldBroken() { }
    }
}