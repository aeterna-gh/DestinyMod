namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class ChamberedCompensator : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Chambered Compensator";
            traitDescription =
                "Stable barrel attachment. \n" +
                "+10 Recoil Control \n" +
                "+10 Stability \n" +
                "-5 Handling \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statStability += 10;
            weapon.statRecoilDirection += 10;
            weapon.statHandling -= 5;

            base.TraitEffect(weapon);
        }
    }
}