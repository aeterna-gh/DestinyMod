namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class ArrowheadBrake : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Arrowhead Brake";
            traitDescription =
                "Lightly vented barrel. \n" +
                "+30 Recoil Control \n" +
                "+10 Handling \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statRecoilDirection += 30;
            weapon.statHandling += 10;

            base.TraitEffect(weapon);
        }
    }
}