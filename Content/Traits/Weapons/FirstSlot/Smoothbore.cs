namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class Smoothbore : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Smoothbore";
            traitDescription = 
                "Smooth shotgun barrel. \n" +
                "+15 Range \n" +
                "-15% Pellet spread increase \n";
            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statRange += 15;

            base.TraitEffect(weapon);
        }
    }
}