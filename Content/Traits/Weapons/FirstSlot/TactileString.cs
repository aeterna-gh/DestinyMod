namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class TactileString : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Tactile String";
            traitDescription = 
                "Subtle, high-friction bowstring. \n" +
                "+10 Stability \n" +
                "+5 Accuracy \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statStability += 10;
            weapon.statAccuracy += 5;

            base.TraitEffect(weapon);
        }
    }
}