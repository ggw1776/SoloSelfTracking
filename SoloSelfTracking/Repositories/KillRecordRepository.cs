using Microsoft.EntityFrameworkCore;
using SoloSelfTracking.Data;
using SoloSelfTracking.Models;

namespace SoloSelfTracking.Repositories
{
    public class KillRecordRepository
    {
        private readonly IDbContextFactory<AppDbContext> _dbFactory;

        public KillRecordRepository(
            IDbContextFactory<AppDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<List<KillRecord>> GetAllAsync()
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            return await db.KillRecords
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

        public async Task<KillRecord?> GetByIdAsync(int id)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            return await db.KillRecords.FindAsync(id);
        }

        public async Task AddAsync(KillRecord record)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            db.KillRecords.Add(record);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            var record = await db.KillRecords.FindAsync(id);

            if (record is null)
                return;

            db.KillRecords.Remove(record);
            await db.SaveChangesAsync();
        }
    }
}
