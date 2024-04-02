using Auction.Data;
using Auction.Repository.IRepository;

namespace Auction.Repository
{
    public class UnitOfWorks : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IPlayersRepository Players {get; private set;}

        public UnitOfWorks(ApplicationDbContext db)
        {
            _db = db;
            Players = new PlayersRepository(_db);
         
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
