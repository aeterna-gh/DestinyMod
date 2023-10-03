namespace DestinyMod.Core.Loaders
{
    //this is likely incorrect... ask for assistance later.

    public interface ILoadableEntity<T> where T : ModType
    {
        void Add(T entity);
        
        void Get(int index);

        void Load(Mod mod);

        void Unload();
    }

    internal class LoadManager<T> where T : ModType
    {
        private readonly List<T> _content;

        public int Count => _content.Count;

        public int Add(T entity, ILoadableEntity<T> loadable)
        {
            int count = Count;

            _content.Add(entity);

            loadable.Add(entity);

            return count;
        }

        public bool TryGet(int index, ILoadableEntity<T> loadable, out T entity)
        {
            loadable.Get(index);

            if (index < 0 || index >= _content.Count)
            {
                entity = default;
                return false;
            }

            else
            {
                entity = _content[index];
                return true;
            }
        }

        public void LoadContent(Mod mod, ILoadableEntity<T> loadable)
        {
            loadable.Load(mod);


        }

        public void UnloadContent(ILoadableEntity<T> loadable)
        {
            loadable.Unload();

            _content.Clear();
        }
    }
}