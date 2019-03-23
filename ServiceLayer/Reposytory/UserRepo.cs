using DomainLayer.Model;
using DomainLayer.Reposytory;
using System.Linq;

namespace ServiceLayer.Reposytory
{
    public class UserRepo : BaseRepo<User>, IUserReposytory<User>
    {
        public UserRepo()
        {
            Table = Context.Users;
        }

        public bool IsUserPresentDB(string login, string password)
        {
            var querry = (from users in Table
                         where (users.Login == login & users.Password == password)
                         select users).ToList();
            return (querry.Capacity>0);
        }
    }
}
