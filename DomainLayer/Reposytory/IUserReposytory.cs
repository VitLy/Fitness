using DomainLayer.Model;

namespace DomainLayer.Reposytory
{
    public interface IUserReposytory<TUser> : IReposytory<TUser>
    {
        User GetUserFromDB(string user, string password);
    }
}
