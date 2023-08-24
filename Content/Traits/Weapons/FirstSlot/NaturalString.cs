namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class NaturalString : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Natural String";
            traitDescription = 
                "Simple, balanced string. \n" +
                "+5 Accuracy \n" +
                "+5 Stability \n" +
                "+5 Handling \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statAccuracy += 5;
            weapon.statStability += 5;
            weapon.statHandling += 5;

            base.TraitEffect(weapon);
        }
    }
}