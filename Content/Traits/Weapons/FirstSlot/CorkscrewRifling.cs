namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class CorkscrewRifling : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Corkscrew Rifling";
            traitDescription =
                "Balanced barrel. \n" +
                "+5 Range \n" +
                "+5 Stability \n" +
                "+5 Handling \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statRange += 5;
            weapon.statStability += 5;
            weapon.statHandling += 5;

            base.TraitEffect(weapon);
        }
    }
}