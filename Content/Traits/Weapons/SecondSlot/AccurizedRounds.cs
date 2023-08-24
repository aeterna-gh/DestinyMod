namespace DestinyMod.Content.Traits.Weapons.SecondSlot
{
    [Autoload(false)]
    internal class AccurizedRounds : Trait
    {
        public override void SetDefaults()
        {
            traitName = "Accurized Rounds";
            traitDescription = 
                "This weapon fires at longer distances. \n" +
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