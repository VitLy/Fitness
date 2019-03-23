using DomainLayer.Model;
using System;

namespace DomainLayer.Reposytory
{
    public interface IBodyReposytory<TParam> : IReposytory<TParam>
    {
        Param SelectParam(DateTime date);
        Param SelectParam();
        Param SelectDefaultParam();
        int AddDailyParameters(Param bodyParam);
    }
}
