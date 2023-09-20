using DestinyMod.Content.Traits.Weapons.FirstSlot;
using System.Threading.Tasks;
using Terraria.ModLoader.Core;

namespace DestinyMod.Core.Loaders
{
    public static class TraitLoader
    {
        public static class TraitDefs
        {
            #region BARREL SET A (rifles, hcs, etc.)

            public static Trait ArrowheadBrake { get; internal set; }
            public static Trait ChamberedCompensator { get; internal set; }
            public static Trait CorkscrewRifling { get; internal set; }
            public static Trait ExtendedBarrel { get; internal set; }
            public static Trait FlutedBarrel { get; internal set; }
            public static Trait FullBore { get; internal set; }
            public static Trait HammerForgedRifling { get; internal set; }
            public static Trait PolygonalRifling { get; internal set; }
            public static Trait Smallbore { get; internal set; }

            #endregion

            #region BARREL SET B (shotguns)

            public static Trait BarrelShroud { get; internal set; }
            public static Trait FullChoke { get; internal set; }
            public static Trait RifledBarrel { get; internal set; }
            public static Trait Smoothbore { get; internal set; }

            #endregion

            #region BARREL SET C (bows)

            public static Trait AgileBowstring { get; internal set; }
            public static Trait ChainBowstring { get; internal set; }
            public static Trait ElasticString { get; internal set; }
            public static Trait FlexibleString { get; internal set; }
            public static Trait HighTensionString { get; internal set; }
            public static Trait NaturalString { get; internal set; }
            public static Trait PolymerString { get; internal set; }
            public static Trait TactileString { get; internal set; }

            #endregion

            #region BARREL SET D (sidearms)

            #endregion

            #region BARREL SET E (rls, gls, etc.)

            #endregion

            #region SPECIAL

            public static Trait BaitAndSwitch { get; internal set; }
            public static Trait KillTally { get; internal set; }

            #endregion

            #region EXOTIC // WEAPON

            

            #endregion

            #region EXOTIC // ARMOR



            #endregion
        }

        private static readonly List<Trait> _traits = new();

        public static int Count => _traits.Count;

        internal static int Add(Trait trait)
        {
            int count = Count;

            _traits.Add(trait);

            return count;
        }

        public static Trait Get(int index) => index < 0 || index >= _traits.Count ? null : _traits[index];

        internal static void Load()
        {
            DestinyMod mod = DestinyMod.Instance;

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                foreach (var type in assembly.GetTypes())
                    if (type.BaseType == typeof(Trait))
                        type.GetMethod("LoadTrait", BindingFlags.Public).Invoke(null, null);

            mod.AddContent(TraitDefs.ArrowheadBrake = new ArrowheadBrake());
            mod.AddContent(TraitDefs.ChamberedCompensator = new ChamberedCompensator());
            mod.AddContent(TraitDefs.CorkscrewRifling = new CorkscrewRifling());
            mod.AddContent(TraitDefs.ExtendedBarrel = new ExtendedBarrel());
            mod.AddContent(TraitDefs.FlutedBarrel = new FlutedBarrel());
            mod.AddContent(TraitDefs.FullBore = new FullBore());
            mod.AddContent(TraitDefs.HammerForgedRifling = new HammerForgedRifling());
            mod.AddContent(TraitDefs.PolygonalRifling = new PolygonalRifling());
            mod.AddContent(TraitDefs.Smallbore = new Smallbore());

            mod.AddContent(TraitDefs.BarrelShroud = new BarrelShroud());
            mod.AddContent(TraitDefs.FullChoke = new FullChoke());
            mod.AddContent(TraitDefs.RifledBarrel  = new RifledBarrel());
            mod.AddContent(TraitDefs.Smoothbore  = new Smoothbore());
        }

        internal static void Unload()
        {
            foreach (var field in typeof(TraitDefs).GetFields().Where(f => f.FieldType == typeof(Trait)))
                field.SetValue(null, null);

            _traits.Clear();
        }
    }
}