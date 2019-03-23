using DomainLayer.DocumentViewModel;
using System.Collections;
using System.Collections.Generic;

namespace DomainLayer.Reposytory
{
    public interface ITrainingProgramHeadReposytory<TParam> : IReposytory<TParam>
    {
        IEnumerable GetBindedData(int id); // проверить на использование
        IEnumerable<TrainigProgramSpecView> GetTrainigProgramSpec(int trainigProgramHeadId);
    }
}
