namespace DestinyMod.Content.Traits.Weapons.SecondSlot
{
    [Autoload(false)]
    internal class AppendedMag : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Appended Mag";
            traitDescription = 
                "This weapon's magazine is built for higher capacity. \n" +
                "+ % Magazine Increase";

            base.SetDefaults();
        }

        public override void TraitEffect(Weapon weapon)
        {
            //Magazine stuff is complicated atm.

            //Should be a percentage of magazine max.

            base.TraitEffect(weapon);
        }
    }
}