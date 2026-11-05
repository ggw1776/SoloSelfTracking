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
    }
}
