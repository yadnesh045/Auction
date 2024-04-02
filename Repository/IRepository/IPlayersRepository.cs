using Auction.Models;

namespace Auction.Repository.IRepository
{
    public interface IPlayersRepository : IRepository<Players>
    {
        void Update(Players obj);
    }
}