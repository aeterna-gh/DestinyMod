namespace DestinyMod.Content.Classes
{
    [Autoload(false)]
    public class Hunter : PlayerClass
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
    public class Gunslinger : PlayerSubclass
    {
        public override void SetDefaults()
        {

            base.SetDefaults();
        }
    }

    [Autoload(false)]
    public class Arcstrider : PlayerSubclass
    {

    }

    [Autoload(false)]
    public class Nightstalker : PlayerSubclass
    {

    }

    [Autoload(false)]
    public class Revenant : PlayerSubclass 
    { 
    
    }

    [Autoload(false)]
    public class Threadrunner : PlayerSubclass
    {

    }
}