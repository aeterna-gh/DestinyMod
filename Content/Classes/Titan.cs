namespace DestinyMod.Content.Classes
{
    [Autoload(false)]
    public class Titan : PlayerClass
    {
        public override void SetDefaults()
        {
            classSubclasses ??= new()
            {
                PlayerSubclassLoader.Get(SubclassID.Striker),
                PlayerSubclassLoader.Get(SubclassID.Behemoth),
                PlayerSubclassLoader.Get(SubclassID.Berserker),
                PlayerSubclassLoader.Get(SubclassID.Sunbreaker),
                PlayerSubclassLoader.Get(SubclassID.Sentinel)
            };

            base.SetDefaults();
        }
    }

    [Autoload(false)]
    public class Sunbreaker : PlayerSubclass
    {
        public override void SetDefaults()
        {
            element = ElementLoader.Get(ElementID.Solar);

            grenadeAbilities ??= new()
            {

            };

            meleeAbilities ??= new()
            {

            };

            superAbilities ??= new()
            {

            };

            base.SetDefaults();
        }
    }

    [Autoload(false)]
    public class Striker : PlayerSubclass
    {
        public override void SetDefaults()
        {
            element = ElementLoader.Get(ElementID.Arc);

            grenadeAbilities ??= new()
            {

            };

            meleeAbilities ??= new()
            {

            };

            superAbilities ??= new()
            {

            };

            base.SetDefaults();
        }
    }

    [Autoload(false)]
    public class Sentinel : PlayerSubclass
    {
        public override void SetDefaults()
        {
            element = ElementLoader.Get(ElementID.Void);

            grenadeAbilities ??= new()
            {

            };

            meleeAbilities ??= new()
            {

            };

            superAbilities ??= new()
            {

            };

            base.SetDefaults();
        }
    }

    [Autoload(false)]
    public class Behemoth : PlayerSubclass
    {
        public override void SetDefaults()
        {
            element = ElementLoader.Get(ElementID.Stasis);

            grenadeAbilities ??= new()
            {

            };

            meleeAbilities ??= new()
            {

            };

            superAbilities ??= new()
            {

            };

            base.SetDefaults();
        }
    }

    [Autoload(false)]
    public class Berserker : PlayerSubclass
    {
        public override void SetDefaults()
        {
            element = ElementLoader.Get(ElementID.Strand);

            grenadeAbilities ??= new()
            {

            };

            meleeAbilities ??= new()
            {

            };

            superAbilities ??= new()
            {

            };

            base.SetDefaults();
        }
    }
}