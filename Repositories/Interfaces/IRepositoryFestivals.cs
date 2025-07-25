﻿using ShowTime.Models;

namespace ShowTime.Repositories.Interfaces{

    public interface IRepositoryFestivals : IRepositoryBase<Festival>
    {
        Task<IEnumerable<Festival>> GetUpcomingFestivalsAsync(DateTime fromDate);
        Task<Festival> GetFestivalByNameAsync(string festivalName);
        Task<IEnumerable<Festival>> GetAllDataAsync();
    }
}