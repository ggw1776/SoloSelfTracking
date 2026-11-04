using System.Text.Json;
using SoloSelfTracking.Models;

namespace SoloSelfTracking.Utilities;

public class SettingsService
{
    private readonly string _settingsPath;
    private readonly SemaphoreSlim _lock = new(1, 1);

    private Settings _settings = new();

    public event Action? OnSettingsChanged;

    public SettingsService()
    {
        var dataDirectory = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "SoloSelfTracking");

        Directory.CreateDirectory(dataDirectory);

        _settingsPath = Path.Combine(dataDirectory, "settings.json");
    }

    public Settings GetSettings()
    {
        return new Settings
        {
            EnablePasteOnFocusIn = _settings.EnablePasteOnFocusIn,
            ClearClipboardOnValidPaste = _settings.ClearClipboardOnValidPaste,
            EnableIframing = _settings.EnableIframing
        };
    }

    public async Task LoadAsync()
    {
        await _lock.WaitAsync();

        try
        {
            if (!File.Exists(_settingsPath))
            {
                _settings = new Settings();
                await SaveToFileAsync();
                return;
            }

            var json = await File.ReadAllTextAsync(_settingsPath);

            _settings = JsonSerializer.Deserialize<Settings>(json)
                        ?? new Settings();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to load settings: {ex.Message}");
            _settings = new Settings();
        }
        finally
        {
            _lock.Release();
        }
    }

    public async Task UpdateAsync(Settings settings)
    {
        await _lock.WaitAsync();

        try
        {
            _settings = settings;
            await SaveToFileAsync();
        }
        finally
        {
            _lock.Release();
        }

        OnSettingsChanged?.Invoke();
    }

    private async Task SaveToFileAsync()
    {
        var json = JsonSerializer.Serialize(
            _settings,
            new JsonSerializerOptions { WriteIndented = true });

        var tempPath = _settingsPath + ".tmp";

        await File.WriteAllTextAsync(tempPath, json);
        File.Move(tempPath, _settingsPath, true);
    }
}