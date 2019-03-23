using DomainLayer.DocumentViewModel;
using DomainLayer.Model;
using DomainLayer.Reposytory;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ServiceLayer.Reposytory
{
    public class TrainigProgramHeadRepo : BaseRepo<TrainingProgramHead>, ITrainingProgramHeadReposytory<TrainingProgramHead>
    {
        public TrainigProgramHeadRepo()
        {
            Table = Context.TrainingProgramHeads;
        }

        public IEnumerable GetBindedData(int id)
        {
            var trPr = Context.TrainingProgramSpecs;
            var set = Context.Sets;

            var querry = from tp in trPr
                         join st in set
                         on tp.Id equals st.TrPrSpecId
                         where tp.ProgramHeadId == id
                         orderby st.SetNum, tp.Id
                         select new { Number = st.SetNum, tp.Exercise.Name, st.Weight, Amount = st.SetAmount };

            return querry.ToList();
        }

        public IEnumerable<TrainigProgramSpecView> GetTrainigProgramSpec(int trainigProgramHeadId)
        {
            List<TrainigProgramSpecView> table = new List<TrainigProgramSpecView>();

            var trPr = Context.TrainingProgramSpecs;
            var set = Context.Sets;
            var querry = from tp in trPr 
                         join st in set
                         on tp.Id equals st.TrPrSpecId
                         where tp.ProgramHeadId == trainigProgramHeadId
                         orderby st.SetNum, tp.Id
                         select new { Number = st.SetNum, tp.Exercise.Name, st.Weight, Amount = st.SetAmount };

            foreach (var item in querry)
            {
                table.Add(new TrainigProgramSpecView() { Set = item.Number, Exercise = item.Name, Weight = item.Weight, Amount = item.Amount });
            }

            return table;
        }
    }
}
