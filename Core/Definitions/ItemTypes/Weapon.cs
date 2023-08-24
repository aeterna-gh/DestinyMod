namespace DestinyMod.Core.Definitions.ItemTypes
{
    public abstract class Weapon : DestinyItem
    {
        public AmmoType ammoType;

        public Archetype weaponArchetype;

        public Element weaponDamageType;

        #region STATS

        /// <summary>
        /// The range this weapon's projectiles travel.
        /// </summary>
        public int statRange;

        /// <summary>
        /// The amount of recoil control this weapon has.
        /// </summary>
        public int statStability;

        /// <summary>
        /// The ready and stow speed of this weapon.
        /// </summary>
        public int statHandling;

        /// <summary>
        /// The speed at which you can reload this weapon.
        /// </summary>
        public int statReloadSpeed;

        /// <summary>
        /// I don't know how to implement this yet so it's just there for accuracy's sake, 'K?
        /// </summary>
        public int statRecoilDirection;

        /// <summary>
        /// The blast radius of explosive projectiles. Only set for Rocket Launchers and Grenade Launchers!
        /// </summary>
        public int statBlastRadius;

        /// <summary>
        /// The speed at which projectiles fired from this weapon travel. Only set for Rocket Launchers and Grenade Launchers!
        /// </summary>
        public int statVelocity;

        /// <summary>
        /// Affects arrow hit consistency at longer ranges or when hip fired. Only set for Bows!
        /// </summary>
        public int statAccuracy;

        /// <summary>
        /// The amount of drain your shield takes while in use. Only set for Glaives!
        /// </summary>
        public int statShieldDuration;

        #endregion

        public int magazineCurrent, magazineMax;

        public int ammoCurrent, ammoMax;

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

        public virtual void SetDefaultStats(Weapon weapon)
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

        #region CLONING

        public override bool IsCloneable => true;

        public override ModItem Clone(Item newEntity)
        {
            return base.Clone(newEntity);
        }

        #endregion

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

        public override bool CanUseItem(Player player)
        {
            return base.CanUseItem(player);
        }

        public enum AmmoType
        {
            Primary,
            Special,
            Heavy
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

        public WeaponData(int range, int stability, int handling, int reloadspeed, int velocity, int accuracy, int shielddur)
        {
            Range = range;
            Stability = stability;
            Handling = handling;
            ReloadSpeed = reloadspeed;
        }
    }
}