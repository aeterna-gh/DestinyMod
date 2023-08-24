namespace DestinyMod
{
	public class DestinyMod : Mod
	{
        internal static DestinyMod Instance => ModContent.GetInstance<DestinyMod>();

        public override void Load()
        {
            ElementLoader.Load();

            PlayerClassLoader.Load();

            PlayerSubclassLoader.Load();

            TraitLoader.Load();

            base.Load();
        }

        public override void Unload()
        {
            ElementLoader.Unload();

            PlayerClassLoader.Unload();

            PlayerSubclassLoader.Unload();

            TraitLoader.Unload();

            base.Unload();
        }
    }
}