namespace Auction.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IPlayersRepository Players { get; }
     
        void Save();
    }
}
