namespace DomainLayer.Reposytory
{
    public interface IUserReposytory<TUser> : IReposytory<TUser>
    {
        bool IsUserPresentDB(string user, string password);
    }
}
