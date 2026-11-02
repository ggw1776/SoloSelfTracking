using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoloSelfTracking.Models;
using System.Text.Json;

namespace SoloSelfTracking.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<KillRecord> KillRecords => Set<KillRecord>();
        public DbSet<SimulacrumRecord> SimulacrumRecords => Set<SimulacrumRecord>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*var dropsConverter = new ValueConverter<List<string>, string>(
                drops => JsonSerializer.Serialize(drops, (JsonSerializerOptions?)null),
                json => JsonSerializer.Deserialize<List<string>>(
                    json, (JsonSerializerOptions?)null) ?? new List<string>());*/
            var dropsConverter = new ValueConverter<List<KillRecordDrop>, string>(
                waves => JsonSerializer.Serialize(waves, (JsonSerializerOptions?)null),
                json => JsonSerializer.Deserialize<List<KillRecordDrop>>(
                    json,
                    (JsonSerializerOptions?)null
                ) ?? new List<KillRecordDrop>()
            );

            modelBuilder.Entity<KillRecord>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.Date)
                    .IsRequired();

                entity.Property(x => x.Boss)
                    .IsRequired();

                entity.Property(x => x.Drops)
                    .HasConversion(dropsConverter)
                    .IsRequired();
            });

            var simuDropsConverter = new ValueConverter<List<SimulacrumWave>, string>(
                waves => JsonSerializer.Serialize(waves, (JsonSerializerOptions?)null),
                json => JsonSerializer.Deserialize<List<SimulacrumWave>>(
                    json,
                    (JsonSerializerOptions?)null
                ) ?? new List<SimulacrumWave>()
            );

            modelBuilder.Entity<SimulacrumRecord>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.Date)
                    .IsRequired();

                entity.Property(x => x.Arena)
                    .IsRequired();

                entity.Property(x => x.Waves)
                    .HasConversion(simuDropsConverter)
                    .IsRequired(); 
                
                entity.Ignore(x => x.UniqueDrops);
            });
        }
    }
}
