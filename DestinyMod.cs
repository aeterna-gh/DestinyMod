namespace DestinyMod
{
	public class DestinyMod : Mod
	{
        internal static DestinyMod Instance => ModContent.GetInstance<DestinyMod>();

        public List<string> windowTitles;

        internal void UpdateWindowTitle()
        {
            int randTitle = Main.rand.Next(0, windowTitles.Count - 1);

            Main.instance.Window.Title = windowTitles[randTitle];
        }

        internal void LoadWindowTitles()
        {
            windowTitles ??= new()
            {
                "[DestinyMod]: Blam!",
                "[DestinyMod]: Error. Bungie.net, satisfying your mom since 1991! Error",
                "[DestinyMod]: It's a thing!",
                "[DestinyMod]: It's on your head.",
                "[DestinyMod]: Leaned on any railways lately?",
                "[DestinyMod]: Taco says no.",
                "[DestinyMod]: That is not a thing.",
                "[DestinyMod]: The amusement fair is for recreational use only.",
                "[DestinyMod]: There's a ball around here somewhere.",
                "[DestinyMod]: You are a great Guardian, and your mom is a classy lady."
            };
        }

        public override void Load()
        {
            LoadWindowTitles();

            On_ResourcePackList.CreatePacksFromDirectories += FindResourcePack;

            ArchetypeLoader.Load();

            DestinyRarityLoader.Load();

            ElementLoader.Load();

            PlayerClassLoader.Load();

            PlayerSubclassLoader.Load();

            SubArchetypeLoader.Load();

            TraitLoader.Load();

            base.Load();
        }

        private void FindResourcePack(On_ResourcePackList.orig_CreatePacksFromDirectories orig, IServiceProvider services, string searchPath, List<ResourcePack> resourcePacks)
        {
            searchPath = "DestinyMod/Assets/resources";

            ResourcePack packToAdd = new(services, searchPath, ResourcePack.BrandingType.None);

            if (packToAdd is null) //add more checks here (exists, is identified correctly)
                return; //error and return orig

            else 
                resourcePacks.Add(packToAdd);

            orig.Invoke(services, searchPath, resourcePacks);
        }

        public override void Unload()
        {
            ArchetypeLoader.Unload();

            DestinyRarityLoader.Unload();

            ElementLoader.Unload();

            PlayerClassLoader.Unload();

            PlayerSubclassLoader.Unload();

            SubArchetypeLoader.Unload();

            TraitLoader.Unload();

            base.Unload();
        }
    }
}