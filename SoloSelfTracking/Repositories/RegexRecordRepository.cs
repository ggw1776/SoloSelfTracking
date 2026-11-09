using Microsoft.EntityFrameworkCore;
using SoloSelfTracking.Data;
using SoloSelfTracking.Models;

namespace SoloSelfTracking.Repositories
{
    public class RegexRecordRepository
    {
        private readonly IDbContextFactory<AppDbContext> _dbFactory;

        public RegexRecordRepository(
            IDbContextFactory<AppDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<List<RegexRecord>> GetAllAsync()
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            return await db.RegexRecords
                .ToListAsync();
        }

        public async Task<RegexRecord?> GetByIdAsync(int id)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            return await db.RegexRecords.FindAsync(id);
        }

        public async Task AddAsync(RegexRecord record)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            db.RegexRecords.Add(record);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();

            var record = await db.RegexRecords.FindAsync(id);

            if (record is null)
                return;

            db.RegexRecords.Remove(record);
            await db.SaveChangesAsync();
        }
    }
}
