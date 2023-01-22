using FantasyFootballAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FantasyFootballAPI.Repositories
{
    public class PlayerRepository : IRepositoryBase<Player>
    {
        private readonly FFContext _context;

        public PlayerRepository(FFContext context)
        {
            _context = context;
        }

        public async Task<Player> Create(Player entity)
        {
            var result = await _context.Player.AddAsync(entity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async void Delete(Player entity)
        {
            var result = await _context.Player.FirstOrDefaultAsync(x => x.Id == entity.Id);

            if(result != null)
            {
                _context.Player.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public IQueryable<Player> FindAll()
        {
        }

        public IQueryable<Player> FindByCondition(Expression<Func<Player, bool>> expression)
        {
        }

        public void Update(Player entity)
        {
        }
    }
}
