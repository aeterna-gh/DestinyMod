namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class HammerForgedRifling : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Hammer-Forged Rifling";
            traitDescription =
                "Durable ranged barrel. \n" +
                "+10 Range \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statRange += 10;

            base.TraitEffect(weapon);
        }
    }
}