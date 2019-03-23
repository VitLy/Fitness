using System;
using System.Collections.Generic;

namespace DomainLayer.Reposytory
{
    public interface ICategoryReposytory<TParam>:IReposytory<TParam>
    {
      //  List<String> GetCategoryList();

        int GetIdbyName(string Name);
    }
}
