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
            new(Currencies.OrbOfDominance, 3f)
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
            new(MiscItems.RealityFragment, 0f, true)
        ];

        public readonly static List<BossDrop> Citadel =
        [
            new(Uniques.Manastorm, 5f),
            new(Gems.CastOnWardBreakSupport, 5f),
            new(MiscItems.CosmicFragment, 0f, true),
            new(MiscItems.SynthesisingFragment, 0f, true)
        ];

        public readonly static List<BossDrop> Fortress =
        [
            new(Uniques.YokeOfSuffering, 5f),
            new(Gems.OverloadedIntensitySupport, 5f),
            new(MiscItems.DecayingFragment, 0f, true),
            new(MiscItems.SynthesisingFragment, 0f, true)
        ];

        public readonly static List<BossDrop> Sanctuary =
        [
            new(Uniques.TheDarkSeer, 5f),
            new(Uniques.UnholyAccomplice, 0.1f),
            new(Gems.ScornfulHeraldSupport, 5f),
            new(Gems.PactOfLycia, 1f),
            new(MiscItems.LonelyFragment, 0f, true),
            new(MiscItems.TraumaticFragment, 0f, true),
            new(MiscItems.ReverentFragment, 0f, true)
        ];

        public readonly static List<BossDrop> Ziggaurat =
        [
            new(Uniques.Wraithlord, 5f),
            new(Gems.CommunionSupport, 5f),
            new(MiscItems.BlazingFragment, 0f, true),
            new(MiscItems.DevouringFragment, 0f, true)
        ];

        public readonly static List<BossDrop> Shaper =
        [
            new(Uniques.ShapersTouch, 56f),
            new(Uniques.Voidwalker, 30f),
            new(Uniques.SolsticeVigil, 11f),
            new(Uniques.DyingSun, 3f),
            new(Gems.VoidstormSupport, 10f),
            new(Currencies.ShapersExaltedOrb, 13f, true),
            new(Currencies.OrbOfDominance, 3f)
        ];
    }
}
