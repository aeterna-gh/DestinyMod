namespace DestinyMod.Core.Loaders
{
    public class AbilityLoader : Loader<Ability>, ILoaderEntity<Ability>
    {
        internal class AbilityDefs 
        { 
            public static Ability NovaWarp { get; internal set; }
        }

        public void Add(int count, Ability entity, out int newCount, out Ability newEntity)
        {
            newCount = count;
            newEntity = entity;
        }

        public void Get(int index, List<Ability> contentList)
        {
            throw new NotImplementedException();
        }

        public void Load(Mod mod)
        {
            mod.AddContent(AbilityDefs.NovaWarp = null);
        }

        public void Unload()
        {
            throw new NotImplementedException();
        }
    }
}