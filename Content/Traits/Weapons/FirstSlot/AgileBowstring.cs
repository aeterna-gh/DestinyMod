namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class AgileBowstring : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Agile Bowstring";
            traitDescription = 
                "Durable yet light bowstring. \n" +
                "+15 Handling \n" +
                "+5 Stability \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statHandling += 15;
            weapon.statStability += 5;

            base.TraitEffect(weapon);
        }
    }
}