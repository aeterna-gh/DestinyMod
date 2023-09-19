namespace DestinyMod.Core.Definitions.ItemTypes
{
    public abstract class Weapon : DestinyItem
    {
        public AmmoType ammoType;

        public Archetype weaponArchetype;

        public Element weaponDamageType;

        public int ammoCurrent;

        public int ammoMax;

        public int magazineCurrent;

        public int magazineMax;

        public int statAccuracy;

        public int statBlastRadius;

        public int statHandling;

        public int statRange;

        public int statRecoilDirection;

        public int statReloadSpeed;

        public int statStability;

        public int statVelocity;

        public int statShieldDuration;

        public SubArchetype weaponSubArchetype;

        /// <summary>
        /// Allows you to set the defaults of this weapon's stat data. <para></para>
        /// Create a new instance and set range, stability, etc.
        /// </summary>
        public WeaponData weaponData;

        public List<Trait> traitList;

        public List<Trait> traitPool;

        /// <summary>
        /// Resets all stats and internal values to their default states. <para></para>
        /// Use this to reset any data that's no longer conditionally satisfied.
        /// </summary>
        public virtual void ResetDefaults()
        {
            statRange = 0;
            statStability = 0;
            statHandling = 0;
            statReloadSpeed = 0;
            statRecoilDirection = 0;
            statBlastRadius = 0;
            statVelocity = 0;
            statAccuracy = 0;
            statShieldDuration = 0;

            if (ammoType is AmmoType.Primary)
            {
                ammoMax = -1;
                ammoCurrent = -1;
            }

            else
            {
                ammoMax = 0;
                magazineMax = 0;
            }
        }

        public void SetDefaultStats(Weapon weapon)
        {
            weapon.statRange += weapon.weaponData.Range;
            weapon.statStability += weapon.weaponData.Stability;
            weapon.statHandling += weapon.weaponData.Handling;
            weapon.statReloadSpeed += weapon.weaponData.ReloadSpeed;

            weapon.statVelocity += weapon.weaponData.Velocity;

            weapon.statAccuracy += weapon.weaponData.Accuracy;

            weapon.statShieldDuration += weapon.weaponData.ShieldDuration;

            weapon.ammoMax = ammoMax;
            weapon.magazineMax = magazineMax;
        }

        internal void RollWeaponTraits()
        {

        }

        #region CLONING

        public override bool IsCloneable => true;

        public override ModItem Clone(Item newEntity)
        {
            return base.Clone(newEntity);
        }

        #endregion

        public override void OnCreated(ItemCreationContext context)
        {


            base.OnCreated(context);
        }

        public override void SetDefaults()
        {
            Item.maxStack = 1;

            base.SetDefaults();
        }

        public override void UpdateInventory(Player player)
        {
            ResetDefaults();

            SetDefaultStats(this);

            foreach (Trait trait in traitList)
                trait.TraitEffect(this);

            weaponSubArchetype.SubArchEffect(this);

            base.UpdateInventory(player);
        }

        public enum AmmoType
        {
            Primary,
            Special,
            Heavy
        }

        public enum WeaponMasterworkType
        {
            Range,
            Stability,
            Handling,
            ReloadSpeed,

            Impact,

            Accuracy,

            DrawSpeed,

            ChargeSpeed,

            Velocity
        }
    }

    public struct WeaponData
    {
        public int Range;
        public int Stability;
        public int Handling;
        public int ReloadSpeed;

        public int Velocity;

        public int Accuracy;

        public int ShieldDuration;

        public WeaponData()
        {
            Range = 0;
            Stability = 0;
            Handling = 0;
            ReloadSpeed = 0;
            Velocity = 0;
            Accuracy = 0;
            ShieldDuration = 0;
        }

        public WeaponData(int range, int stability, int handling, int reloadspeed, int velocity = 0, int accuracy = 0, int shielddur = 0)
        {
            Range = range;
            Stability = stability;
            Handling = handling;
            ReloadSpeed = reloadspeed;

            Velocity = velocity;
            Accuracy = accuracy;
            ShieldDuration = shielddur;
        }
    }
}