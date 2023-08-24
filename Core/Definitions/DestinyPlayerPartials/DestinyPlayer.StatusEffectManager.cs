namespace DestinyMod.Core.Definitions.DestinyPlayerPartials
{
    public partial class DestinyPlayer
    {
        public List<StatusEffect> currentEffects;

        public bool HasEffect(StatusEffect effect)
        {
            if (currentEffects.Contains(effect))
                return true;

            return false;
        }

        public void ApplyEffect(StatusEffect effect)
        {
            if (HasEffect(effect))
                currentEffects.Find(x => x == effect).Reapply();

            else
            {
                currentEffects.Add(effect);
                currentEffects.Find(x => x == effect).effectTimeCurrent = effect.effectTimeMaximum;
                currentEffects.Find(x => x == effect).OnApply();
            }
        }

        public override void PostUpdateBuffs()
        {
            foreach (StatusEffect effect in currentEffects)
                effect.Update(this);

            base.PostUpdateBuffs();
        }
    }
}