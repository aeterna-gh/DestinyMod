namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class ExtendedBarrel : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Extended Barrel";
            traitDescription =
                "Weightly barrel extension. \n" +
                "+10 Recoil Control \n" +
                "+10 Range \n" +
                "-10 Handling \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statHandling -= 10;
            weapon.statRange += 10;

            weapon.statRecoilDirection += 10;

            base.TraitEffect(weapon);
        }
    }
}