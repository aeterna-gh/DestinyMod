namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class BarrelShroud : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Barrel Shroud";
            traitDescription = 
                "Balanced shotgun barrel. \n" +
                "+10 Stability \n" +
                "+10 Handling \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statStability += 10;
            weapon.statHandling += 10;

            base.TraitEffect(weapon);
        }
    }
}