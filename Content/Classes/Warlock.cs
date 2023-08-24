namespace DestinyMod.Content.Classes
{
    [Autoload(false)]
    public class Warlock : PlayerClass
    {
        public override void SetDefaults()
        {
            classSubclasses ??= new()
            {

            };

            base.SetDefaults();
        }
    }

    [Autoload(false)]
    public class Dawnblade : PlayerSubclass
    {

    }

    [Autoload(false)]
    public class Stormcaller : PlayerSubclass
    {

    }

    [Autoload(false)]
    public class Voidwalker : PlayerSubclass 
    { 
    
    }

    [Autoload(false)]
    public class Shadebinder : PlayerSubclass
    {

    }

    [Autoload(false)]
    public class Broodweaver : PlayerSubclass
    {

    }
}