using Microsoft.EntityFrameworkCore;
using SoloSelfTracking.Data;
using SoloSelfTracking.Models;

namespace SoloSelfTracking.Repositories;

public class SettingsRepository
{
    private readonly IDbContextFactory<AppDbContext> _contextFactory;

    public SettingsRepository(
        IDbContextFactory<AppDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<Settings> GetAsync()
    {
        await using var db = await _contextFactory.CreateDbContextAsync();

        var settings = await db.Settings
            .FirstOrDefaultAsync(x => x.Id == 1);

        if (settings != null)
            return settings;

        settings = new Settings { Id = 1 };

        db.Settings.Add(settings);
        await db.SaveChangesAsync();

        return settings;
    }

    public async Task SaveAsync(Settings settings)
    {
        await using var db = await _contextFactory.CreateDbContextAsync();

        var existing = await db.Settings
            .FirstOrDefaultAsync(x => x.Id == 1);

        if (existing == null)
        {
            settings.Id = 1;
            db.Settings.Add(settings);
        }
        else
        {
            existing.EnablePasteOnFocusIn = settings.EnablePasteOnFocusIn;
            existing.ClearClipboardOnValidPaste = settings.ClearClipboardOnValidPaste;
            existing.EnableIframing = settings.EnableIframing;
            existing.EnableLogReader = settings.EnableLogReader;
            existing.ClearClipboardOnValidPaste = settings.ClearClipboardOnValidPaste;
            existing.EnableTeleportScrollNotification = settings.EnableTeleportScrollNotification;
            existing.EnableAutomaticTimerStart = settings.EnableAutomaticTimerStart;
            existing.EnableShopMusic = settings.EnableShopMusic;
            existing.EnableMoralSupport = settings.EnableMoralSupport;
            existing.EnableTradieDetector = settings.EnableTradieDetector;
            existing.EnableAutoTabNavigation = settings.EnableAutoTabNavigation;
            existing.EnableAutoDeathCounter = settings.EnableAutoDeathCounter;
            existing.EnableAutoMapParse = settings.EnableAutoMapParse;
            existing.EnablePauseTimerOnEnterHideout = settings.EnablePauseTimerOnEnterHideout;
        }

        await db.SaveChangesAsync();
    }
}