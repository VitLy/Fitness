using DomainLayer.Model;
using System.Collections.Generic;

namespace DomainLayer.Reposytory
{
    public interface IExerciseReposytory<TExercise>:IReposytory<TExercise>
    {
        IEnumerable<TExercise> GetAllExercises();
        void Modify(Exercise modifyedExercise);
        List<string> GetExerciseList();
        int GetIdbyName(string Name);
    }
}
