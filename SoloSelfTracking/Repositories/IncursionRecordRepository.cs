using Microsoft.EntityFrameworkCore;
using SoloSelfTracking.Data;
using SoloSelfTracking.Models;

namespace SoloSelfTracking.Repositories
{
    public class IncursionRecordRepository
    {
        private readonly IDbContextFactory<AppDbContext> _dbFactory;

        public IncursionRecordRepository(
            IDbContextFactory<AppDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<List<IncursionRecord>> GetAllAsync()
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            return await db.IncursionRecords
                .OrderByDescending(x => x.Date).Include(x => x.OpenRooms).Include(x => x.ObstructedRooms)
                .ToListAsync();
        }

        public async Task<IncursionRecord?> GetByIdAsync(int id)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            return await db.IncursionRecords.FindAsync(id);
        }

        public async Task AddAsync(IncursionRecord record)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            db.IncursionRecords.Add(record);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            var record = await db.IncursionRecords.FindAsync(id);

            if (record is null)
                return;

            db.IncursionRecords.Remove(record);
            await db.SaveChangesAsync();
        }
    }
}
