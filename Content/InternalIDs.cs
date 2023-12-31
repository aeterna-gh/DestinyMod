﻿namespace DestinyMod.Content
{
    public class InternalIDs
    {
        public enum AbilityID
        {
            //grenades first

            //melees second

            //classes third
            Barricade_Rally,
            Barricade_Towering,
            Rift_Healing,
            Rift_Empowering,
            PhoenixDive,

            //supers fourth
            ArcStaff,
            BladeBarrage,
            BurningMaul,
            ChaosReach,
            Daybreak,
            FistsOfHavoc,
            GlacialQuake,
            GoldenGun_Deadshot,
            GoldenGun_Marksman,
            HammerOfSol,
            NovaBomb_Cataclysm,
            NovaBomb_Vortex,
            NovaWarp,
            SentinelShield,
            Shadowshot_Deadfall,
            Shadowshot_MoebiusQuiver,
            SilenceAndSquall,
            SpectralBlades,
            Stormtrance,
            Thundercrash,
            WardOfDawn,
            WellOfRadiance,
            WintersWrath,
        }

        public enum ArchetypeID
        {
            AutoRifle,
            Bow,
            BreechGrenadeLauncher,
            FusionRifle,
            Glaive,
            GrenadeLauncher,
            HandCannon,
            LinearFusionRifle,
            MachineGun,
            PulseRifle,
            ScoutRifle,
            Shotgun,
            Sidearm,
            SniperRifle,
            SubmachineGun,
            Sword,
            TraceRifle
        }

        public enum ClassID
        {
            Hunter,
            Titan,
            Warlock
        }

        public enum ElementID
        {
            Arc = 0,
            Solar,
            Stasis,
            Strand,
            Void
        }

        public enum FactionID
        {
            Cabal,
            Fallen,
            Hive,
            Scorn,
            Taken,
            Vex
        }

        public enum RarityID
        {
            Common,
            Uncommon,
            Rare,
            Legendary,
            Exotic
        }

        public enum SubArchetypeID 
        { 
            Adaptive,
            AdaptiveBurst,
            Aggressive,
            AggressiveBurst,
            HakkePrecision,
            HighImpact,
            Lightweight,
            OmolonAdaptive,
            PinpointSlug,
            Precision,
            RapidFire,
            SurosRapidFire,
            VeistRapidFire,
            VortexFrame,
            WaveFrame,
        }

        public enum SubclassID
        {
            Gunslinger,
            Arcstrider,
            Nightstalker,
            Revenant,
            Threadrunner,

            Sunbreaker,
            Striker,
            Sentinel,
            Behemoth,
            Berserker,

            Dawnblade,
            Stormcaller,
            Voidwalker,
            Shadebinder,
            Broodweaver
        }

        //the absolute bane of my existence right here.
        public enum TraitID
        {
            //BARREL (1st Slot)

            ArrowheadBrake,
            ChamberedCompensator,
            CorkscrewRifling,
            ExtendedBarrel,
            FlutedBarrel,
            FullBore,
            HammerforgedRifling,
            PolygonalRifling,
            Smallbore,

            BarrelShroud,
            FullChoke,
            RifledBarrel,
            Smoothbore,

            AgileBowstring,
            ChainBowstring,
            ElasticString,
            FlexibleString,
            HighTensionString,
            NaturalString,
            PolymerString,
            TactileString,

            ControlSAS,
            FarpointSAS,
            QuickdotSAS,
            ShortspecSAS,
            TacticSAS,
            TargetSAS,

            ConfinedLaunch,
            Countermass,
            HardLaunch,
            LinearCompensator,
            QuickLaunch,
            SmartDriftControl,
            VoltaileLaunch,

            //MAG (2nd Slot)

            AccurizedRounds,
            AlloyMagazine,
            AppendedMag,
            ArmorPiercingRounds,
            ExtendedMag,
            FlaredMagwell,
            HighCaliberRounds,
            LightMag,
            RicochetRounds,
            SteadyRounds,
            TacticalMag,

            AssaultMag,

            EnhancedBattery,
            IonizedBattery,
            LightBattery,
            LiquidCoils,
            ParticleRepeater,
            ProjectionFuse,
            TacticalBattery,

            AntiTakenFletching,
            CarbonArrowShaft,
            CompactArrowShaft,
            FiberglassArrowshaft,
            HelicalFletching,
            NaturalFletching,
            StraightFletching,

            AlloyCasing,
            AugmentedDrum,
            BlackPowder,
            HighExplosiveOrdnance,
            HighVelocityRounds,
            MiniFrags,
            ProximityGrenades,
            SpikeGrenades,

            //SPECIAL (3rd and 4th)

            #region SPECIAL

            AdaptiveMunitions,
            AmbitiousAssassin,
            AssassinsBlade,
            AutoLoadingHolster,
            CascadePoint,
            ChainReaction,
            ClownCartridge,
            Desperado,
            DisruptionBreak,
            Dragonfly,
            DynamicSwayReduction,
            ElementalCapacitor,
            Encore,
            ExplosiveLight,
            EyeOfTheStorm,
            FeedingFrenzy,
            FieldPrep,
            FiringLine,
            FocusedFury,
            Frenzy,
            FullCourt,
            GoldenTricorn,
            GutshotStraight,
            Harmony,
            Headseeker,
            Headstone,
            HeatingUp,
            HipFireGrip,
            ImpulseAmplifier,
            Incandescent,
            KillClip,
            KillingTally,
            KillingWind,
            MovingTarget,
            Mulligan,
            NoDistractions,
            OffhandStrike,
            OneForAll,
            Outlaw,
            PerfectFloat,
            PerpetualMotion,
            Pugilist,
            Quickdraw,
            Rampage,
            Rangefinder,
            RapidHit,
            RepulsorBrace,
            ShootToLoot,
            ShotSwap,
            Slickdraw,
            StatsForAll,
            SteadyHands,
            Subsistence,
            Swashbuckler,
            TapTheTrigger,
            TirelessBlade,
            TripleTap,
            TunnelVision,
            Underover,
            Voltshot,
            VorpalWeapon,

            #endregion

            //STOCK (4th or 5th)

            CompositeStock,
            FittedStock,
            HandlaidStock,
            ShortactionStock,

            //GRIP (4th or 5th)

            CombatGrip,
            HeavyGrip,
            PolymerGrip,
            SmoothGrip,
            TexturedGrip,

            //ORIGIN

            Alacrity,
            Ambush,
            ExplosivePact,
            HakkeBreachArmaments,
            HakkeHeavyBurstFire,
            HakkeLightBurstFire,
            LandTank,
            NobleDeeds,
            OmolonFluidDynamics,
            OneQuietMoment,
            Psychohack,
            RasputinsArsenal,
            RunnethOver,
            StunningRecovery,
            SurosSynergy,
            VanguardsVindication,
            VeistStinger,

            //EXOTIC WEAPONS

            #region EXOTIC TRAITS
            
            Accomplice,
            AdaptiveOrdnance,
            AgersCall,
            AhamkarasEye,
            AllAtOnce,
            ApollonicTangent,
            ArcConductor,
            ArcTraps,
            ArmorOfTheColossus,
            BannedWeapon,
            BansheesWail,
            BeTheDanger,
            BigFrigidGlaive,
            BigGameHunter,
            BlackHole,
            BlessingOfTheSky,
            BottomlessAppetite,
            BreakTheBank,
            Breakthrough,
            Broadside,
            BusinessTime,
            CausalityArrows,
            ChargedWithBlight,
            ChargeShot,
            CloseTheGap,
            ColdFusion,
            CompoundingForce,
            CompressionChamber,
            ConserveMomentum,
            Cosmology,
            CranialSpike,
            CrowsWings,
            CruelRemedy,
            Cryocannon,
            DarkDeliverance,
            DarkDescent,
            DeathAtFirstGlance,
            DelayedGratification,
            Dornroschen,
            DualSpeedReceiver,
            DynamicCharge,
            EdgeOfAction,
            EdgeOfConcurrence,
            EdgeOfIntent,
            EMAnomaly,
            Evolution,
            Excavation,
            Exhumation,
            ExplosiveShadow,
            EyesOnAll,
            FanFire,
            Firefly,
            FlameRefraction,
            ForTheEmpire,
            FourheadedDog,
            FullStop,
            GatheringLight,
            GiftOfTheTraveler,
            GrenadeChaser,
            GrenadesAndHorseshoes,
            GuidanceRing,
            HailBarrage,
            HailStorm,
            HarbingersPulse,
            HarmonicLaser,
            HarshTruths,
            HeatSink,
            HeavyMetal,
            HeavySlugThrower,
            HonedEdge,
            HuntersTrace,
            IgnitionTrigger,
            Impetus,
            InsectoidRobotGrenades,
            IonicReturn,
            Judgement,
            LagrangianSight,
            LastStand,
            LeviathansSigh,
            LightningRod,
            LightningRounds,
            LightningSeeker,
            LiquidCooling,
            LN2Burst,
            LongestWinter,
            LongMarch,
            LooksCanKill,
            M1RDistributionMatrix,
            MadScientist,
            MarkOfTheDevourer,
            MarkovChain,
            MechanizedAutoloader,
            MementoMori,
            MIDAMultiTool,
            MIDARadar,
            MonteCarloMethod,
            MortalPolarity,
            NobleRounds,
            OmegaStrike,
            OnBlackWings,
            OverchargeCapacitor,
            PaceYourself,
            PackHunter,
            ParacausalPellets,
            ParacausalShot,
            Parasitism,
            Payday,
            Penance,
            PerpetualLoophole,
            PersonalAssistant,
            PickYourPoison,
            PlayWithYourPrey,
            PoisonArrows,
            PrecisionSlug,
            PrimevalsTorment,
            PrismaticInferno,
            ProtectiveWeave,
            PrototypeTrueseeker,
            Pyrogenesis,
            PyrotoxinRounds,
            QueensWrath,
            RatPack,
            RavenousBeast,
            RegasRefrain,
            RegenerativeMotion,
            ReignHavoc,
            ReleaseTheWolves,
            RemoteShield,
            RepulsorForce,
            Revolution,
            RevvedConsumption,
            RestorativeTurret,
            RewindAgain,
            RideTheBull,
            RocketTracers,
            SaintsFists,
            SacredFlame,
            ScreamingSwarm,
            ServeTheColony,
            ShatterShot,
            ShockBlast,
            ShotInTheDark,
            ShrapnelLauncher,
            SlugRifle,
            SoaringFang,
            SoulDevourer,
            SpinningUp,
            SplitDecision,  
            SplitElectron,
            SpreadShotPackage,
            StormAndStress,
            Stormbringer,
            StringOfCurses,
            SunBlast,
            Sunburn,
            SuperchargedBattery,
            Superconductor,
            SurosLegacy,
            SwoopingTalons,
            TakenPredator,
            TargetAcquired,
            TempestCascade,
            TemporalUnlimiter,
            Tesseract,
            TheCorruptionSpreads,
            TheFateOfAllFools,
            TheFundamentals,
            ThePerfectFifth,
            TheRoadborn,
            TheScientificMethod,
            ThinTheHerd,
            Thunderer,
            TimelessMythoclast,
            Timeslip,
            TouchOfMalice,
            ToxicOverload,
            TraitorsVessel,
            Transmutation,
            TrinaryVision,
            TwinTails,
            UmbralSustenance,
            UnforeseenReprocussions,
            Unrepentant,
            UnplannedReprieve,
            Vermin,
            Vexadecimal,
            VoidLeech,
            VolatileLight,
            WeftCutter,
            WeightedEdge,
            WhiteNail,
            WireRifle,
            WolfpackRounds,
            WormByproduct,
            WormsHunger,
            WrathOfTheColossus,

            #endregion

            //EXOTIC ARMOR

            #region EXOTIC TRAITS 2

            //HUNTER

            //TITAN

            //WARLOCK

            #endregion
        }
    }
}