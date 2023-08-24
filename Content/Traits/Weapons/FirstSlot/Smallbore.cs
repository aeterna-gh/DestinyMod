namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class Smallbore : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Smallbore";
            traitDescription = 
                "Dual strength barrel. \n" +
                "+7 Range \n" +
                "+7 Stability \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statRange += 7;
            weapon.statStability += 7;

            base.TraitEffect(weapon);
        }
    }
}