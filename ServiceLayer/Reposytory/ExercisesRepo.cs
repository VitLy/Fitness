using System.Collections.Generic;
using DomainLayer.Model;
using DomainLayer.Reposytory;
using System.Linq;

namespace ServiceLayer.Reposytory
{
    public class ExercisesRepo:BaseRepo<Exercise>,IExerciseReposytory<Exercise>
    {
        public ExercisesRepo()
        {
            Table = Context.Exercises;
        }

        public IEnumerable<Exercise> GetAllExercises()
        {
            return GetAll();
        }

        public void Modify(Exercise modifyedExercise)
        {
            var exerciseToUpdate = Table.Find(modifyedExercise.Id);
            exerciseToUpdate.Name = modifyedExercise.Name;
            exerciseToUpdate.Description = modifyedExercise.Description;
            Save(exerciseToUpdate);
        }

        public List<string> GetExerciseList()
        {
            List<string> list = new List<string>();
            List<Exercise> allExerciseRecords = GetAll() as List<Exercise>;

            var querry = from exercise in allExerciseRecords
                         select new {exercise.Id, exercise.Name };

            foreach (var item in querry)
            {
                list.Add(item.Name);
            }
            return list;
        }

        public int GetIdbyName(string name)
        {
            var result = from ex in Table
                         where ex.Name == name
                         select ex.Id;
            return result.ToList()[0];
        }
    }
}
