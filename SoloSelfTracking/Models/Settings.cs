namespace SoloSelfTracking.Models
{
    public class Settings
    {
        public int Id { get; set; }
        public bool EnablePasteOnFocusIn { get; set; } = false;
        public bool ClearClipboardOnValidPaste { get; set; } = false;
        public bool EnableIframing { get; set; } = false;
        public bool EnableLogReader { get; set; } = false;
        public bool EnableTeleportScrollNotification { get; set; } = false;
        public bool EnableAutomaticTimerStart { get; set; } = false;
        public bool EnableShopMusic { get; set;  } = false;
        public bool EnableMoralSupport { get; set; } = false;
        public bool EnableTradieDetector { get; set; } = false;
        public bool EnableAutoTabNavigation { get; set; } = false;
        public bool EnableAutoDeathCounter { get; set; } = false;
        public bool EnableAutoMapParse { get; set; } = false;
        public bool EnablePauseTimerOnEnterHideout { get; set; } = false;

        public bool EnableWikiSearch { get; set; } = false;
        public bool EnablePoeDbSearch { get; set; } = false;
        public bool EnableHideOnSearch { get; set; } = false;
        public bool EnableSmartDisplay{ get; set; } = false;

        //pages

        public bool EnableFates { get; set; } = true;
        public bool EnableAnomaly { get; set; } = true;
        public bool EnableSimulacrum { get; set; } = true;
        public bool EnableSanctum { get; set; } = true;
        public bool EnableIncursion { get; set; } = true;
        public bool EnableNightmares { get; set; } = true;
        public bool EnableBosses { get; set; } = true;
        public bool EnableInviteBosses { get; set; } = true;
        public bool EnableUbers { get; set; } = true;
        public bool EnableT0s { get; set; } = true;
        public bool EnableTimeline { get; set; } = true;
        public bool EnableStash { get; set; } = true;
        public bool EnableRegexDictionary { get; set; } = true;
        public bool EnableHeist { get; set; } = true;
        public bool EnableLab { get; set; } = true;
        public bool EnableWombgifts { get; set; } = true;
        public bool EnableMappingStrats { get; set; } = true;
        public bool EnableExpedition { get; set; } = true;
        public bool EnableKingsmarchShipping { get; set; } = true;
        public bool EnableKingsmarchMapping { get; set; } = true;
        public bool EnableBlight { get; set; } = true;
    }
}
