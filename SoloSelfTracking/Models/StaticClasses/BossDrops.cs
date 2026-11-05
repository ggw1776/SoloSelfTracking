namespace SoloSelfTracking.Models.StaticClasses
{
    public static class BossDrops
    {
        public readonly static List<BossDrop> UberSirus =
        [
            new(Uniques.ThreadofHope, 44f),
            new(Uniques.TheTempestRising, 28f),
            new(Uniques.ZanasIngenuity, 18f),
            new(Uniques.OriathsEnd, 9f),
            new(Uniques.TheSaviour, 1f),
            new(MiscItems.OublietteReliquaryKey, 1.5f),
            new(Gems.AnnihilationSupport, 7f),
            new(Currencies.OrbOfDominance, 5f),
            new(Currencies.AwakenersOrb, 20f),
            new(DivinationCards.AFateWorseThanDeath, 4f)
        ];

        public readonly static List<BossDrop> UberShaper =
        [
            new(Uniques.Starforge, 2f),
            new(Uniques.SublimeVision, 2f), //todo - variants
            new(Uniques.EchoesofCreation, 32f),
            new(Uniques.EntropicDevastation, 31f),
            new(Uniques.TheUnblinkingEye, 19f),
            new(Uniques.TheTidesofTime, 16f),
            new(MiscItems.CosmicReliquaryKey, 1f),
            new(Gems.VoidstormSupport, 10f),
            new(Currencies.ShapersExaltedOrb, 13f),
            new(Currencies.OrbOfDominance, 3f),
            new(MiscItems.FragmentofKnowledge, 50f),
            new(MiscItems.FragmentofShape, 50f),
        ];

        public readonly static List<BossDrop> UberUberElder =
        [
            new(Uniques.WatchersEye, 35f), //todo watchers eye handling
            new(Uniques.Voidforge, 1.5f),
            new(Uniques.CalloftheVoid, 46f),
            new(Uniques.TheDevourerofMinds, 28.5f),
            new(Uniques.Impresence, 10f), //todo impresence handling
            new(Uniques.SoulAscension, 9f),
            new(Uniques.TheEternityShroud, 5f),
            new(Uniques.SublimeVision, 1.5f),
            new(MiscItems.DecayingReliquaryKey, 1.5f),
            new(MiscItems.CurioOfDecay, 5f),
            new(Gems.VoidShockwaveSupport, 10f),
            new(Currencies.ShapersExaltedOrb, 13f),
            new(Currencies.EldersExaltedOrb, 13f),
            new(Currencies.OrbOfDominance, 6f),
            new(DivinationCards.VoidOfTheElements, 0.05f),
            new(DivinationCards.AuspiciousAmbitions, 0.5f)
        ];

        public readonly static List<BossDrop> UberMaven = [
            new(Uniques.ViridisVeil, 52f),
            new(Uniques.ImpossibleEscape, 31.5f), //todo escape handling
            new(Uniques.GraceoftheGoddess, 14f),
            new(Uniques.Progenesis, 2.5f),
            new(Gems.AwakenedEmpowerSupport, 0.6f),
            new(Gems.AwakenedEnhanceSupport, 1f),
            new(Gems.AwakenedEnlightenSupport, 0.5f),
            new(Gems.EclipseSupport, 2f),
            new(MiscItems.ShinyReliquaryKey, 0.7f),
            new(MiscItems.CurioOfPotential, 5f),
            new(Gems.InvertTheRulesSupport, 10f),
            new(Currencies.OrbOfConflict, 32f),
            new(DivinationCards.AuspiciousAmbitions, 0.05f)
        ];

        public readonly static List<BossDrop> UberCortex = [
            new(Uniques.Nebulis, 34f),
            new(Uniques.MaskoftheTribunal, 34f),
            new(Uniques.CircleofAmbition, 19f),
            new(Uniques.TheApostate, 8f),
            new(Uniques.RationalDoctrine, 5f),
            new(MiscItems.ForgottenReliquaryKey, 1.5f),
            new(Gems.GreaterKineticInstabilitySupport, 10f),
            new(DivinationCards.TheHook, 5f),
            new(DivinationCards.ImperfectMemories, 0.5f)
        ];

        public readonly static List<BossDrop> UberExarch = [
            new(Uniques.TheAnnihilatingLight, 45.5f),
            new(Uniques.AnnihilationsApproach, 29f),
            new(Uniques.CrystallisedOmniscience, 24f),
            new(Uniques.TheCelestialBrace, 1.5f),
            new(Uniques.ForbiddenFlame, 5f), //todo FF/FF handling
            new(Currencies.ExceptionalEldritchEmber, 15f),
            new(MiscItems.ArchiveReliquaryKey, 1.5f),
            new(MiscItems.CurioOfConsumption, 5f),
            new(Gems.OverheatSupport, 1f),
            new(Currencies.EldrichOrbOfAnnulment, 5f),
            new(Currencies.EldrichChaosOrb, 5f),
            new(Currencies.EldrichExaltedOrb, 5f),
            new(DivinationCards.AuspiciousAmbitions, 1f)
        ];

        public readonly static List<BossDrop> UberEater = [

            new(Uniques.RavenousPassion, 68f),
            new(Uniques.AshesOfTheStars, 30f),
            new(Uniques.Nimis, 2f),
            new(Uniques.ForbiddenFlesh, 5f),  //todo FF/FF handling
            new(Currencies.ExceptionalEldrichIchor, 15f),
            new(MiscItems.VisceralReliquaryKey, 1.5f),
            new(MiscItems.CurioOfConsumption, 5f),
            new(Gems.GluttonySupport, 1f),
            new(Currencies.EldrichOrbOfAnnulment, 5f),
            new(Currencies.EldrichChaosOrb, 5f),
            new(Currencies.EldrichExaltedOrb, 5f),
            new(DivinationCards.AuspiciousAmbitions, 1f)
        ];

        public readonly static List<BossDrop> UberAtziri = [
            new(Uniques.AtzirisSplendour, 42f), //todo - does anyone care about the variants
            new(Uniques.TheVertex, 40f),
            new(Uniques.AtzirisAcuity, 6f),
            new(Uniques.TriumvirateAuthority, 5f),
            new(Uniques.AtzirisReflection, 4f),
            new(Uniques.AtzirisDisfavour, 2f),
            new(Uniques.AtzirisRule, 1f),
            new(MiscItems.Beauty, 15f),
            new(Gems.VaalSacrificeSupport, 8f),
            new(DivinationCards.Triskaidekaphobia, 20f),
            new(DivinationCards.ThePriceOfDevotion, 0.1f),
            new(new EquipmentItem( "Sacrificial Garb", Enumerations.EItemType.SacrificialGarb, Enumerations.EItemRarity.Normal), 15f)
        ];

        public readonly static List<BossDrop> UberIncarnationOfFear = [
            new(Uniques.TheCagedMammoth, 60f),
            new(Uniques.CoilingWhisper, 36f),
            new(Uniques.WingoftheWyvern, 2f),
            new(Uniques.Woespike, 2f),
            new(Uniques.BoundByDestiny, 10f),  //todo bbd handling
            new(Gems.GreaterDevourSupport, 5f),
            new(MiscItems.TraumaticReliquaryKey, 1f),
            new(Currencies.OrbOfIntention, 33f),
            new(Currencies.TemplarAstrolabe, 33f),
            new(Currencies.ChaoticAstrolabe, 7.5f),
            new(Currencies.DeceptiveAstrolabe, 7.5f),
            new(Currencies.FruitingAstrolabe, 7.5f),
            new(Currencies.FungalAstrolabe, 7.5f),
            new(Currencies.GraspingAstrolabe, 7.5f),
            new(Currencies.LightlessAstrolabe, 7.5f),
            new(Currencies.NamelessAstrolabe, 7.5f),
            new(Currencies.RunicAstrolabe, 7.5f),
            new(Currencies.TimelessAstrolabe, 7.5f),
            new(DivinationCards.Monochrome, 3f)
        ];
        public readonly static List<BossDrop> UberIncarnationOfNeglect = [
            new(Uniques.RefugeinIsolation, 55f),
            new(Uniques.BitterInstinct, 30f),
            new(Uniques.HauntingMemories, 13f),
            new(Uniques.FesteringResentment, 2f),
            new(MiscItems.LonleyReliquaryKey,1f),
            new(Uniques.BoundByDestiny, 10f),
            new(Gems.FrostmageSupport, 5f),
            new(Currencies.TemplarAstrolabe, 33f),
            new(Currencies.ChaoticAstrolabe, 7.5f),
            new(Currencies.DeceptiveAstrolabe, 7.5f),
            new(Currencies.FruitingAstrolabe, 7.5f),
            new(Currencies.FungalAstrolabe, 7.5f),
            new(Currencies.GraspingAstrolabe, 7.5f),
            new(Currencies.LightlessAstrolabe, 7.5f),
            new(Currencies.NamelessAstrolabe, 7.5f),
            new(Currencies.RunicAstrolabe, 7.5f),
            new(Currencies.TimelessAstrolabe, 7.5f),
            new(DivinationCards.Monochrome, 3f)
        ];
        public readonly static List<BossDrop> UberIncarnationOfDread = [
            new(Uniques.TheHallowedMonarch, 54f),
            new(Uniques.WhispersOfInfinity, 30f),
            new(Uniques.WellwaterPhylactery, 14f),
            new(Uniques.TheGoldenCharlatan, 2f),
            new(MiscItems.ReverentReliquaryKey,1f),
            new(Uniques.BoundByDestiny, 10f),
            new(Gems.CongregationSupport, 5f),
            new(Currencies.TemplarAstrolabe, 33f),
            new(Currencies.ChaoticAstrolabe, 7.5f),
            new(Currencies.DeceptiveAstrolabe, 7.5f),
            new(Currencies.FruitingAstrolabe, 7.5f),
            new(Currencies.FungalAstrolabe, 7.5f),
            new(Currencies.GraspingAstrolabe, 7.5f),
            new(Currencies.LightlessAstrolabe, 7.5f),
            new(Currencies.NamelessAstrolabe, 7.5f),
            new(Currencies.RunicAstrolabe, 7.5f),
            new(Currencies.TimelessAstrolabe, 7.5f),
            new(DivinationCards.Monochrome, 3f)
        ];

        // NMs

        public readonly static List<BossDrop> Abomination =
        [
            new(Uniques.MalachaisMark, 5f),
            new(Gems.UnholyTrinitySupport, 5f),
            new(MiscItems.AwakeningFragment, 0f, true),
            new(MiscItems.RealityFragment, 0f, true),
            new(DivinationCards.TheVoid, 0f, true)
        ];

        public readonly static List<BossDrop> Citadel =
        [
            new(Uniques.Manastorm, 5f),
            new(Gems.CastOnWardBreakSupport, 5f),
            new(MiscItems.CosmicFragment, 0f, true),
            new(MiscItems.SynthesisingFragment, 0f, true),
            new(DivinationCards.TheVoid, 0f, true)
        ];

        public readonly static List<BossDrop> Fortress =
        [
            new(Uniques.YokeOfSuffering, 5f),
            new(Gems.OverloadedIntensitySupport, 5f),
            new(MiscItems.DecayingFragment, 0f, true),
            new(MiscItems.SynthesisingFragment, 0f, true),
            new(DivinationCards.TheVoid, 0f, true)
        ];

        public readonly static List<BossDrop> Sanctuary =
        [
            new(Uniques.TheDarkSeer, 5f),
            new(Uniques.UnholyAccomplice, 0.1f),
            new(Gems.ScornfulHeraldSupport, 5f),
            new(Gems.PactOfLycia, 1f),
            new(MiscItems.LonelyFragment, 0f, true),
            new(MiscItems.TraumaticFragment, 0f, true),
            new(MiscItems.ReverentFragment, 0f, true),
            new(DivinationCards.TheVoid, 0f, true)
        ];

        public readonly static List<BossDrop> Ziggaurat =
        [
            new(Uniques.Wraithlord, 5f),
            new(Gems.CommunionSupport, 5f),
            new(MiscItems.BlazingFragment, 0f, true),
            new(MiscItems.DevouringFragment, 0f, true),
            new(DivinationCards.TheVoid, 0f, true)
        ];

        public readonly static List<BossDrop> Shaper =
        [
            new(Uniques.ShapersTouch, 56f),
            new(Uniques.Voidwalker, 30f),
            new(Uniques.SolsticeVigil, 11f),
            new(Uniques.DyingSun, 3f),
            new(Gems.VoidstormSupport, 10f),
            new(Currencies.ShapersExaltedOrb, 13f, true),
            new(Currencies.OrbOfDominance, 3f),
            new(MiscItems.FragmentofKnowledge, 50f),
            new(MiscItems.FragmentofShape, 50f),
        ];

        public readonly static List<BossDrop> Elder =
        [
            new(Uniques.CyclopeanCoil, 30f),
            new(Uniques.BlasphemersGrasp, 26f),
            new(Uniques.Impresence_Physical, 4f),
            new(Uniques.Impresence_Fire, 4f),
            new(Uniques.Impresence_Cold, 4f),
            new(Uniques.Impresence_Lightning, 4f),
            new(Uniques.Impresence_Chaos, 4f),
            new(Uniques.Hopeshredder, 8f),
            new(Uniques.Nebuloch, 8f),
            new(Uniques.Shimmeron, 8f),
            new(Uniques.WatchersEye, 40f),
            new(Gems.EldrichBlasphemySupport, 10f),
            new(Currencies.OrbOfDominance, 2f),
            new(Currencies.EldersExaltedOrb, 12f),
            new(DivinationCards.VoidOfTheElements, 0.5f),
            new(MiscItems.FragmentofTerror, 50f),
            new(MiscItems.FragmentofEmptiness, 50f),
        ];
        public readonly static List<BossDrop> Cortex =
        [
            new(Uniques.OfferingtotheSerpent, 43f),
            new(Uniques.Perepiteia, 43f),
            new(Uniques.GarboftheEphemeral, 9f),
            new(Uniques.BottledFaith, 5f),
            new(Gems.GreaterKineticInstabilitySupport, 10f),
            new(DivinationCards.TheHook, 5f),
            new(DivinationCards.ImperfectMemories, 0.5f)
        ];
        public readonly static List<BossDrop> Sirus =
        [
            new(Uniques.HandsoftheHighTemplar, 43f),
            new(Uniques.CrownoftheInwardEye, 32f),
            new(Uniques.TheBurdenofTruth, 20f),
            new(Uniques.ThreadofHope, 5f),
            new(Gems.AnnihilationSupport, 7f),
            new(Currencies.OrbOfDominance, 5f),
            new(Currencies.AwakenersOrb, 20f),
            new(DivinationCards.AFateWorseThanDeath, 4f)
        ];

        public readonly static List<BossDrop> Maven = 
        [
            new(Uniques.LegacyofFury, 41f),
            new(Uniques.GravensSecret, 17f),
            new(Uniques.ArnsAnguish, 17f),
            new(Uniques.DoppelgängerGuise, 7f),
            new(Uniques.Echoforge, 1f),
            new(Gems.InvertTheRulesSupport, 10f),
            new(Currencies.OrbOfConflict, 32f),
            new(DivinationCards.AuspiciousAmbitions, 0.05f)
        ];

        public readonly static List<BossDrop> Exarch = 
        [
            new(Uniques.Dawnbreaker, 63f),
            new(Uniques.Dawnstrider, 35f),
            new(Uniques.DissolutionoftheFlesh, 2f),
            new(Uniques.ForbiddenFlame, 5f), //todo FF/FF handling
            new(Currencies.ExceptionalEldritchEmber, 15f),
            new(Gems.OverheatSupport, 1f),
            new(Currencies.EldrichOrbOfAnnulment, 5f),
            new(Currencies.EldrichChaosOrb, 5f),
            new(Currencies.EldrichExaltedOrb, 5f),
            new(DivinationCards.AuspiciousAmbitions, 1f)
        ];

        public readonly static List<BossDrop> Eater = 
        [
            new(Uniques.InextricableFate, 55f),
            new(Uniques.TheGluttonousTide, 43f),
            new(Uniques.MeldingoftheFlesh, 2f),
            new(Uniques.ForbiddenFlesh, 5f),  //todo FF/FF handling
            new(Currencies.ExceptionalEldrichIchor, 15f),
            new(Gems.GluttonySupport, 1f),
            new(Currencies.EldrichOrbOfAnnulment, 5f),
            new(Currencies.EldrichChaosOrb, 5f),
            new(Currencies.EldrichExaltedOrb, 5f),
            new(DivinationCards.AuspiciousAmbitions, 1f)
        ];

        public readonly static List<BossDrop> Atziri = 
        [
            new(Uniques.AtzirisPromise, 48f),
            new(Uniques.TriumvirateAuthority, 18f),
            new(Uniques.AtzirisStep, 15f),
            new(Uniques.DoryanisInvitation, 15f),
            new(Uniques.DoryanisCatalyst, 3f),
            new(Uniques.PledgeofHands, 0.5f),
            new(DivinationCards.ThePriceOfDevotion, 0.1f),
            new(new EquipmentItem( "Sacrificial Garb", Enumerations.EItemType.SacrificialGarb, Enumerations.EItemRarity.Normal), 15f)
        ];

        public readonly static List<BossDrop> IncarnationOfFear = [
            new(Uniques.ServantofDecay, 50f),
            new(Uniques.TheUnseenHue, 37f),
            new(Uniques.EnmitysEmbrace, 11f),
            new(Uniques.Starcaller, 2f),
            new(Uniques.BoundByDestiny, 10f),  //todo bbd handling
            new(Gems.GreaterDevourSupport, 5f),
            new(Currencies.OrbOfIntention, 33f),
            new(Currencies.TemplarAstrolabe, 33f),
            new(Currencies.ChaoticAstrolabe, 7.5f),
            new(Currencies.DeceptiveAstrolabe, 7.5f),
            new(Currencies.FruitingAstrolabe, 7.5f),
            new(Currencies.FungalAstrolabe, 7.5f),
            new(Currencies.GraspingAstrolabe, 7.5f),
            new(Currencies.LightlessAstrolabe, 7.5f),
            new(Currencies.NamelessAstrolabe, 7.5f),
            new(Currencies.RunicAstrolabe, 7.5f),
            new(Currencies.TimelessAstrolabe, 7.5f),
            new(DivinationCards.Monochrome, 3f)
        ];
        public readonly static List<BossDrop> IncarnationOfNeglect = [
            new(Uniques.BetrayalsSting, 50f),
            new(Uniques.TheArkhonsTools, 38f),
            new(Uniques.VenariusAstrolabe, 10f),
            new(Uniques.LegacyoftheRose, 2f),
            new(Uniques.BoundByDestiny, 10f),
            new(Gems.FrostmageSupport, 5f),
            new(Currencies.TemplarAstrolabe, 33f),
            new(Currencies.ChaoticAstrolabe, 7.5f),
            new(Currencies.DeceptiveAstrolabe, 7.5f),
            new(Currencies.FruitingAstrolabe, 7.5f),
            new(Currencies.FungalAstrolabe, 7.5f),
            new(Currencies.GraspingAstrolabe, 7.5f),
            new(Currencies.LightlessAstrolabe, 7.5f),
            new(Currencies.NamelessAstrolabe, 7.5f),
            new(Currencies.RunicAstrolabe, 7.5f),
            new(Currencies.TimelessAstrolabe, 7.5f),
            new(DivinationCards.Monochrome, 3f)
        ];
        public readonly static List<BossDrop> IncarnationOfDread = [
            new(Uniques.Bonemeld, 55f),
            new(Uniques.TheDarkMonarch, 35f),
            new(Uniques.SevenTeachings, 8f),
            new(Uniques.WineoftheProphet, 2f),
            new(Uniques.BoundByDestiny, 10f),
            new(Gems.CongregationSupport, 5f),
            new(Currencies.TemplarAstrolabe, 33f),
            new(Currencies.ChaoticAstrolabe, 7.5f),
            new(Currencies.DeceptiveAstrolabe, 7.5f),
            new(Currencies.FruitingAstrolabe, 7.5f),
            new(Currencies.FungalAstrolabe, 7.5f),
            new(Currencies.GraspingAstrolabe, 7.5f),
            new(Currencies.LightlessAstrolabe, 7.5f),
            new(Currencies.NamelessAstrolabe, 7.5f),
            new(Currencies.RunicAstrolabe, 7.5f),
            new(Currencies.TimelessAstrolabe, 7.5f),
            new(DivinationCards.Monochrome, 3f)
        ];

        public readonly static List<BossDrop> Zorath =
        [
            new(Uniques.SubsumetheSource, 40f),
            new(Uniques.Spinesnatch, 20f),
            new(Uniques.BalefulDominion, 10f),
            new(Uniques.DestructiveAspiration, 10f),
            new(Uniques.ExtinguishingGrasp, 10f),
            new(Uniques.FesteringVengeance, 10f),
            new(Gems.CrystalfallSupport, 10f)
        ];

        public readonly static List<BossDrop> BlackStar =
        [
            new(Uniques.PolaricDevastation, 5f),
            new(Uniques.SuddenDawn, 5f),
            new(Uniques.TheEternalStruggle, 5f),
            new(Currencies.EldrichOrbOfAnnulment, 5f),
            new(Currencies.EldrichChaosOrb, 5f),
            new(Currencies.EldrichExaltedOrb, 5f),
            new(Currencies.GrandEldritchEmber, 12f),
            new(Currencies.GreaterEldritchEmber, 20f)
        ];

        public readonly static List<BossDrop> InfiniteHunger =
        [
            new(Uniques.CeaselessFeast, 5f),
            new(Uniques.BlackZenith, 5f),
            new(Uniques.TheEternalStruggle, 5f),
            new(Currencies.EldrichOrbOfAnnulment, 5f),
            new(Currencies.EldrichChaosOrb, 5f),
            new(Currencies.EldrichExaltedOrb, 5f),
            new(Currencies.GrandEldritchIchor, 12f),
            new(Currencies.GreaterEldritchIchor, 20f),
            new(DivinationCards.ChokingGuilt, 1f)
        ];

        public readonly static List<BossDrop> Farrul =
        [
            new(Uniques.NaturalHierarchy, 1f),
            new(Uniques.NightSHold, 1f),
            new(Uniques.RigwaldSCurse, 1f),
            new(Uniques.EyesOfTheGreatwolf, 1f),
            new(Uniques.Blightwell, 1f),
            new(Uniques.FarrulsFur, 25f),
            new(Uniques.FarrulsChase, 25f),
            new(Uniques.FarrulsPounce, 25f),
            new(Uniques.FarrulsBite, 25f),
            new(DivinationCards.HuntersReward, 1f),
            new(DivinationCards.SilenceAndFrost, 1f)
        ];
        public readonly static List<BossDrop> Saqawal =
        [
            new(Uniques.NaturalHierarchy, 1f),
            new(Uniques.NightSHold, 1f),
            new(Uniques.RigwaldSCurse, 1f),
            new(Uniques.EyesOfTheGreatwolf, 1f),
            new(Uniques.Blightwell, 1f),
            new(Uniques.SaqawalsFlock, 25f),
            new(Uniques.SaqawalsWinds, 25f),
            new(Uniques.SaqawalsNest, 25f),
            new(Uniques.SaqawalsTalons, 25f),
            new(DivinationCards.HuntersReward, 1f),
            new(DivinationCards.SilenceAndFrost, 1f)
        ];
        public readonly static List<BossDrop> Fenumus =
        [
            new(Uniques.NaturalHierarchy, 1f),
            new(Uniques.NightSHold, 1f),
            new(Uniques.RigwaldSCurse, 1f),
            new(Uniques.EyesOfTheGreatwolf, 1f),
            new(Uniques.Blightwell, 1f),
            new(Uniques.FenumusShroud, 25f),
            new(Uniques.FenumusSpinnerets, 25f),
            new(Uniques.FenumusToxins, 25f),
            new(Uniques.FenumusWeave, 25f),
            new(DivinationCards.HuntersReward, 1f),
            new(DivinationCards.SilenceAndFrost, 1f)
        ];
        public readonly static List<BossDrop> Craiceann =
        [
            new(Uniques.NaturalHierarchy, 1f),
            new(Uniques.NightSHold, 1f),
            new(Uniques.RigwaldSCurse, 1f),
            new(Uniques.EyesOfTheGreatwolf, 1f),
            new(Uniques.Blightwell, 1f),
            new(Uniques.CraiceannsCarapace, 25f),
            new(Uniques.CraiceannsChitin, 25f),
            new(Uniques.CraiceannsPincers, 25f),
            new(Uniques.CraiceannsTracks, 25f),
            new(DivinationCards.HuntersReward, 1f),
            new(DivinationCards.SilenceAndFrost, 1f)
        ];

        public readonly static List<BossDrop> Ahuatotli =
        [
            new(Uniques.AhkelisMountain, 1f),
            new(Uniques.CerberusLimb, 60f),
            new(MiscItems.DoryanisMachinarium, 16f),
            new(Uniques.PutembosValley, 8f),
            new(Uniques.UzazasMeadow, 8f),
            new(MiscItems.Curiosity, 40f)
        ];

        public readonly static List<BossDrop> Kurgal =
        [
            new(Uniques.AhkelisValley, 10f),
            new(Uniques.CommandofthePit, 20f),
            new(Uniques.HaleNegator, 50f),
            new(Uniques.PutembosMeadow, 10f),
            new(Uniques.UzazasMountain, 10f),
            new(DivinationCards.MiseryInDarkness, 20f),
            new(MiscItems.ZorathsEyeoftheInevitable, 50f)
        ];

        public readonly static List<BossDrop> Aul =
        [
            new(Uniques.AhkelisMeadow, 8f),
            new(Uniques.AulSUprising,  61f),
            new(Uniques.CrownoftheTyrant, 15f),
            new(Uniques.PutembosMountain, 8f),
            new(Uniques.UzazasValley, 8f),
            new(DivinationCards.DesecratedVirtue, 1f),
            new(DivinationCards.LuminousTrove, 16f)
        ];

        public readonly static List<BossDrop> Catarina =
        [
            new(Uniques.CinderswallowUrn, 30f),
            new(Uniques.Spinehail, 20f),
            new(Uniques.TheDevouringDiadem, 16f),
            new(Uniques.BitterbindPoint, 10f),
            new(Uniques.TheQueensHunger, 6f),
            new(Uniques.CaneofKulemak, 17f), //todo - 3 mod vs 4 mod
            new(Gems.CommunionSupport, 10f),
            new(Currencies.VeiledExaltedOrb, 25f),
            new(Currencies.AllflameEmberOfKulemak, 60f),
            new(MiscItems.ZorathsEyeoftheEndless, 50f),
            new(DivinationCards.NooksCrown, 0.5f),
            new(DivinationCards.KeepersCorruption, 1f)
        ];
        public readonly static List<BossDrop> Oshabi =
        [
            new(Uniques.ForbiddenShako, 50f),
            new(Uniques.LawOfTheWilds, 19f),
            new(Uniques.WitchhuntersJudgment, 19f),
            new(Uniques.AbhorrentInterrogation, 12f),
            new(Gems.GreaterUnleashSupport, 10f),
            new(Gems.PacifismSupport, 10f),
            new(DivinationCards.TheAspirant, 14f)
        ];

        public readonly static List<BossDrop> Trialmaster =
        [
            new(Uniques.IxchelsTemptation, 40f),
            new(Uniques.GlimpseofChaos, 40f),
            new(Uniques.YaomacsAccord, 9.5f),
            new(Uniques.MahuxotlsMachination, 9.5f),
            new(Uniques.Hateforge, 1f),
            new(Gems.MachinationsSupport, 10f),
            new(Gems.VaalTemptationSupport, 5f),
            new(Currencies.CorruptedCatalyst, 100f, true),
        ];

        public readonly static List<BossDrop> KingInTheMists =
        [
            new(Uniques.TheUntouchedSoul, 40f),
            new(Uniques.Pragmatism, 35f),
            new(Uniques.TheLightofMeaning, 20f),
            new(Uniques.TheBurdenofShadows, 5f),
            new(Gems.HextoadSupport, 6f),
            new(Gems.HexpassSupport, 10f),
            new(DivinationCards.TheEndlessDarkness, 1f),
        ];

        public readonly static List<BossDrop> BlackKnight =
        [
            new(Uniques.Svalinn, 4f)
        ];

        public readonly static List<BossDrop> ItThatWas =
        [
            new(Uniques.TheWillofEsh, 17f),
            new(Uniques.TheWillofTul, 17f),
            new(Uniques.TheWillofXoph, 17f),
            new(Uniques.TheWillofUulNetol, 12f),
            new(Uniques.TheSunderedWill, 4f),
            new(Uniques.HandoftheLords, 29f),
            new(Uniques.TheGreyWind, 3f),
            new(Uniques.UulNetolSVow, 1f),
            new(MiscItems.FleshofXesht, 20f),
            new(Gems.FoulgraspSupport, 10f),
            new(Gems.HivebornSupport, 5f),
            new(DivinationCards.SomethingDark, 1f),
            new(DivinationCards.TheEscape, 91f),
        ];

        public readonly static List<BossDrop> Incursion =
        [
            new(Uniques.StringofServitude, 46f),
            new(Uniques.TemperedFlesh, 7f),
            new(Uniques.TemperedMind, 7f),
            new(Uniques.TemperedSpirit, 7f),
            new(Uniques.SoulCatcher, 20f),
            new(Uniques.SacrificialHeart, 4f),
            new(Uniques.Shadowstitch, 0f),
            new(Uniques.ApepsSlumber, 0f),
            new(Uniques.ArchitectsHand, 0f),
            new(Uniques.CowardsChains, 0f),
            new(Uniques.DanceoftheOffered, 0f),
            new(Uniques.MaskoftheSpiritDrinker, 0f),
            new(Uniques.StoryoftheVaal, 0f),
            new(MiscItems.VialofDominance, 10f),
            new(MiscItems.VialofSummoning, 17f),
            new(MiscItems.VialofAwakening, 2f),
            new(MiscItems.VialoftheRitual, 17f),
            new(MiscItems.VialofFate, 17f),
            new(MiscItems.VialofConsequence, 8f),
            new(MiscItems.VialofTranscendence, 28f),
            new(MiscItems.VialoftheGhost, 0.2f),
            new(MiscItems.VialofSacrifice, 0.2f),
            new(MiscItems.CitaqualotlBase, 0f),
            new(MiscItems.GuatelitziBase, 0f),
            new(MiscItems.MatatlBase, 0f),
            new(MiscItems.PuhuarteBase, 0f),
            new(MiscItems.TacatiBase, 0f),
            new(MiscItems.XopecBase, 0f),
            //copy of atziri's stuff...
            new(Uniques.AtzirisPromise, 48f),
            new(Uniques.TriumvirateAuthority, 18f),
            new(Uniques.AtzirisStep, 15f),
            new(Uniques.DoryanisInvitation, 15f),
            new(Uniques.DoryanisCatalyst, 3f),
            new(Uniques.PledgeofHands, 0.5f),
            new(DivinationCards.ThePriceOfDevotion, 0.1f),
            new(new EquipmentItem( "Sacrificial Garb", Enumerations.EItemType.SacrificialGarb, Enumerations.EItemRarity.Normal), 15f)
        ];
    }
}
