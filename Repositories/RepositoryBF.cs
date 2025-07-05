using Microsoft.EntityFrameworkCore;
using ShowTime.Data;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementation
{
    public class RepositoryBF : RepositoryBase<BandFestival>, IRepositoryBF
    {
        private readonly ShowTimeContext Context;

        public RepositoryBF(ShowTimeContext context) : base(context)
        {
            Context = context;
        }

        public async Task AddAsync(Guid bandId, Guid festivalId, int order = 1)
        {
            if (!await ExistsAsync(bandId, festivalId))
            {
                Context.BandFestivals.Add(new BandFestival
                {
                    BandID = bandId,
                    FestivalID = festivalId,
                    Order = order
                });

                await Context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(Guid bandId, Guid festivalId)
        {
            return await Context.BandFestivals
                .AnyAsync(bf => bf.BandID == bandId && bf.FestivalID == festivalId);
        }
    }
}