using Auction.Data;
using Auction.Models;
using Auction.Repository.IRepository;

namespace Auction.Repository
{
    public class PlayersRepository : Repository<Players>, IPlayersRepository
    {
        private ApplicationDbContext _db;
        public PlayersRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Players obj)
        {
            _db.Players.Update(obj);
        }
    }
}