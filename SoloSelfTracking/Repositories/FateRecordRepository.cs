using Microsoft.EntityFrameworkCore;
using SoloSelfTracking.Data;
using SoloSelfTracking.Models;

namespace SoloSelfTracking.Repositories
{
    public class FateRecordRepository
    {
        private readonly IDbContextFactory<AppDbContext> _dbFactory;

        public FateRecordRepository(
            IDbContextFactory<AppDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<List<FateRecord>> GetAllAsync()
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            return await db.FateRecords
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

        public async Task<FateRecord?> GetByIdAsync(int id)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            return await db.FateRecords.FindAsync(id);
        }

        public async Task AddAsync(FateRecord record)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            db.FateRecords.Add(record);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            var record = await db.FateRecords.FindAsync(id);

            if (record is null)
                return;

            db.FateRecords.Remove(record);
            await db.SaveChangesAsync();
        }
    }
}
