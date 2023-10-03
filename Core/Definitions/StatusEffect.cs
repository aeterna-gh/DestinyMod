namespace DestinyMod.Core.Definitions
{
    public abstract class StatusEffect : ModType
    {
        public bool isPermanent;

        public bool isStackable;

        public int ID { get; private set; }

        public int effectTimeAddative;

        internal int effectTimeCurrent;

        public int effectTimeMaximum;

        internal int stackCurrent;

        public int stackMaximum;

        public Texture2D iconTexture;

        internal void Reapply()
        {
            if (isStackable)
            {
                stackCurrent++;
                effectTimeCurrent = effectTimeMaximum;
            }

            else
                effectTimeCurrent += effectTimeAddative;

            OnReapply();
        }

        internal void Update(DestinyPlayer player)
        {
            effectTimeCurrent--;
            UpdateEffect(player);

            if (effectTimeCurrent <= 0 && stackCurrent > 0)
            {
                stackCurrent--;
                effectTimeCurrent = effectTimeMaximum;
            }

            else if (stackCurrent == 0)
            {
                OnStackEnd();
                player.currentEffects.Remove(this);
            }
        }

        public virtual void OnApply() { }

        public virtual void OnReapply() { }

        public virtual void OnStackEnd() { }

        public virtual void SetDefaults() { }

        /// <summary> Allows you to make things happen every tick while this buff is active. </summary>
        /// <param name="player"></param>
        public virtual void UpdateEffect(DestinyPlayer player) { }

        protected sealed override void Register()
        {
            ModTypeLookup<StatusEffect>.Register(this);

            ID = StatusEffectLoader.Add(this);
        }

        public sealed override void SetupContent()
        {
            SetDefaults();

            base.SetupContent();
        }
    }
}