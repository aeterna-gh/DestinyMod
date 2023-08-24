namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class FlutedBarrel : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Fluted Barrel";
            traitDescription =
                "Ultra-light barrel. \n" +
                "+15 Handling \n" +
                "+5 Stability \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statStability += 5;
            weapon.statHandling += 15;

            base.TraitEffect(weapon);
        }
    }
}