namespace DestinyMod.Content.Traits.Weapons.FirstSlot
{
    [Autoload(false)]
    public class PolygonalRifling : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Polygonal Rifling";
            traitDescription =
                "Barrel optimized for recoil reduction. \n" +
                "+10 Stability \n";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            weapon.statStability += 10;

            base.TraitEffect(weapon);
        }
    }
}