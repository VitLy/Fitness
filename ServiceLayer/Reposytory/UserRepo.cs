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

        public User GetUserFromDB(string login, string password)
        {
            return Table.Where(x => (x.Login == login&x.Password==password)).FirstOrDefault();
        }
    }
}
