namespace DestinyMod.Core.Loaders
{
    public static class ElementLoader
    {
        public static class ElementDefs
        {
            public static Element Arc { get; internal set; }

            public static Element Kinetic { get; internal set; }

            public static Element Solar { get; internal set; }

            public static Element Stasis { get; internal set; }

            public static Element Strand { get; internal set; }

            public static Element Void { get; internal set; }
        }

        private static readonly List<Element> _elements = new();

        public static int Count => _elements.Count;

        internal static int Add(Element element)
        {
            int count = Count;

            _elements.Add(element);

            return count;
        }

        public static Element Get(int index) => index < 0 || index >= _elements.Count ? null : _elements[index];
        public static Element Get(ElementID index) => (int)index < 0 || (int)index >= _elements.Count ? null : _elements[(int)index];

        internal static void Load()
        {
            DestinyMod mod = DestinyMod.Instance;

            mod.AddContent(ElementDefs.Arc = new Arc());
            mod.AddContent(ElementDefs.Kinetic = new Kinetic());
            mod.AddContent(ElementDefs.Solar = new Solar());
            mod.AddContent(ElementDefs.Stasis = new Stasis());
            mod.AddContent(ElementDefs.Strand = new Strand());
            mod.AddContent(ElementDefs.Void = new Content.Elements.Void());
        }

        internal static void Unload()
        {
            foreach (var field in typeof(ElementDefs).GetFields().Where(f => f.FieldType == typeof(Element)))
                field.SetValue(null, null);

            _elements.Clear();
        }
    }
}