namespace SoloSelfTracking.Models
{
    public class Settings
    {
        public int Id { get; set; }
        public bool EnablePasteOnFocusIn { get; set; } = false;
        public bool ClearClipboardOnValidPaste { get; set; } = false;
        public bool EnableIframing { get; set; } = false;
    }
}
