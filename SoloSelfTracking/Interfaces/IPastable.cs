namespace SoloSelfTracking.Interfaces
{
    public interface IPastable : IAsyncDisposable
    {
        Task<bool> HandleFocusedItem(string pastedText);
        Task<bool> HandlePastedItem(string pastedText);
    }
}
