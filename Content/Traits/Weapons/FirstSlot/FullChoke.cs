namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class FullChoke : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Full Choke";
            traitDescription =
                "Tightened barrel. \n" +
                "+15% Pellet spread reduction \n" +
                "-7.5% Precision damage \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            //we'll handle this later.

            base.TraitEffect(weapon);
        }
    }
}