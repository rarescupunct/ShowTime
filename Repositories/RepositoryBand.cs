using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using ShowTime.Components;
using ShowTime.Data;
using ShowTime.Models;
using ShowTime.Repositories.Implementation.Interfaces;

namespace ShowTime.Repositories.Implementation{

    public class RepositoryBand: RepositoryBase<Band>, IRepositoryBand
    {
        public RepositoryBand(ShowTimeContext context) : base(context)
        {
        }
        
        
    }
}