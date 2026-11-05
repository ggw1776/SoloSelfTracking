namespace SoloSelfTracking.Utilities
{
    public class TriggerService
    {
        public Func<string, Task>? OnTriggerAsync { get; set; }
        public Func<Task>? OnTriggerTimerAsync { get; set; }
        public Func<Task>? OnTriggerDeathAsync { get; set; }
        public Func<Task>? OnTriggerMapParseAsync { get; set; }

        public async Task TriggerNavigateAsync(string location)
        {
            if (OnTriggerAsync != null)
            {
                await OnTriggerAsync.Invoke(location);
            }
        }
        public async Task TriggerTimerAsync()
        {
            if (OnTriggerTimerAsync != null)
            {
                await OnTriggerTimerAsync.Invoke();
            }
        }
        public async Task TriggerDeathAsync()
        {
            if (OnTriggerDeathAsync != null)
            {
                await OnTriggerDeathAsync.Invoke();
            }
        }
        public async Task TriggerMapParseAsync()
        {
            if (OnTriggerMapParseAsync != null)
            {
                await OnTriggerMapParseAsync.Invoke();
            }
        }
    }
}
