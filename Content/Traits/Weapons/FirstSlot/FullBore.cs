namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class FullBore : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Full Bore";
            traitDescription = 
                "Barrel optimized for distance. \n" +
                "+15 Range \n" +
                "-5 Handling \n" +
                "-10 Stability \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statStability -= 10;
            weapon.statRange += 15;
            weapon.statHandling -= 5;

            base.TraitEffect(weapon);
        }
    }
}