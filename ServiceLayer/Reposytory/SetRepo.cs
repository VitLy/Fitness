using DomainLayer.Model;
using DomainLayer.Reposytory;

namespace ServiceLayer.Reposytory
{
    public class SetRepo : BaseRepo<Set>, ISetReposytory<Set>
    {
        public SetRepo()
        {
            Table = Context.Sets;
        }
    }
}
