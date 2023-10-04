namespace DestinyMod.Core.Loaders
{
    //this is likely incorrect... ask for assistance later.

    /// <summary>
    /// Interface designed for allowing custom loading / getting / unloading procedures with the quasi-loader.
    /// </summary>
    /// <typeparam name="T">The ModType you are conducting loading actions on.</typeparam>
    public interface ILoaderEntity<T> where T : ModType
    {
        /// <summary>
        /// Allows you to add special conditions and parameters to adding content to the ID system.
        /// </summary>
        /// <param name="entity"></param>
        void Add(int count, T entity, out int newCount, out T newEntity);
        
        /// <summary>
        /// Allows you to add special conditions and parameters to getting content from the ID system.
        /// </summary>
        /// <param name="index"></param>
        void Get(int index, List<T> contentList);

        /// <summary>
        /// Allows you to add special conditions and parameters to loading procedures.
        /// </summary>
        /// <param name="mod"></param>
        void Load(Mod mod);

        /// <summary>
        /// Allows you to add special conditions and parameters to unloading procedures. 
        /// </summary>
        void Unload();
    }

    public abstract class Loader<T> where T : ModType
    {
        private static readonly List<T> _content;

        public static int Count => _content.Count;

        public static int Add(T entity, ILoaderEntity<T> loadable)
        {
            int count = Count;
            
            loadable?.Add(count, entity, out count, out entity);

            _content.Add(entity);

            return count;
        }

        public static bool TryGetContent(T entity, ILoaderEntity<T> loadable, out List<T> entityList)
        {
            if (entity is null || _content is null)
            {
                entityList = default;
                return false;
            }

            else
            {
                entityList = _content;
                return true;
            }
        }

        public bool TryGet(int index, ILoaderEntity<T> loadable, out T entity)
        {
            loadable?.Get(index, _content);

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

        public static void LoadContent(Mod mod, ILoaderEntity<T> loadable) => loadable?.Load(mod);

        public static void UnloadContent(ILoaderEntity<T> loadable)
        {
            loadable?.Unload();

            _content.Clear();
        }
    }
}