using Microsoft.EntityFrameworkCore;
using SoloSelfTracking.Data;
using SoloSelfTracking.Models;

namespace SoloSelfTracking.Repositories
{
    public class SimulacrumRecordRepository
    {
        private readonly IDbContextFactory<AppDbContext> _dbFactory;

        public SimulacrumRecordRepository(
            IDbContextFactory<AppDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<List<SimulacrumRecord>> GetAllAsync()
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            return await db.SimulacrumRecords
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

        public async Task<SimulacrumRecord?> GetByIdAsync(int id)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            return await db.SimulacrumRecords.FindAsync(id);
        }

        public async Task AddAsync(SimulacrumRecord record)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            db.SimulacrumRecords.Add(record);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            var record = await db.SimulacrumRecords.FindAsync(id);

            if (record is null)
                return;

            db.SimulacrumRecords.Remove(record);
            await db.SaveChangesAsync();
        }
    }
}
