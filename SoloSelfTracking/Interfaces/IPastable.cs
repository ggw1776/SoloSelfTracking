namespace SoloSelfTracking.Interfaces
{
    public interface IPastable : IAsyncDisposable
    {
        Task<bool> HandlePastedItem(string pastedText);
    }
}
