namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class RifledBarrel : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Rifled Barrel";
            traitDescription = 
                "Ranged shotgun barrel. \n" +
                "+10 Range \n" +
                "-15 Handling \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statRange += 10;
            weapon.statHandling -= 15;

            base.TraitEffect(weapon);
        }
    }
}