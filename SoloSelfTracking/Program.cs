using Microsoft.EntityFrameworkCore;
using SoloSelfTracking.Components;
using SoloSelfTracking.Data;
using SoloSelfTracking.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var dataDirectory = Path.Combine(
    Environment.GetFolderPath(
        Environment.SpecialFolder.LocalApplicationData),
    "SoloSelfTracking");

Directory.CreateDirectory(dataDirectory);

var databasePath = Path.Combine(dataDirectory, builder.Configuration.GetValue<string>("Database"));

builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlite($"Data Source={databasePath}"));

builder.Services.AddScoped<KillRecordRepository>();
builder.Services.AddScoped<SimulacrumRecordRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();


// Database
using var scope = app.Services.CreateScope();

var factory = scope.ServiceProvider
    .GetRequiredService<IDbContextFactory<AppDbContext>>();

await using var db = await factory.CreateDbContextAsync();
await db.Database.MigrateAsync();

if (app.Environment.IsDevelopment())
{
    app.Run();
}
else
{
    app.Run(string.Format("http://localhost:{0}", builder.Configuration.GetValue<string>("ServerPort")));
}