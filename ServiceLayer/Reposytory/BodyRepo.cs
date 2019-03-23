using DomainLayer.Model;
using DomainLayer.Reposytory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer.Reposytory
{
    public class BodyRepo : BaseRepo<Param>, IBodyReposytory<Param>
    {
        const float weight = 100;
        const int breast = 100;
        const int buttock = 100;
        const int waist = 100;
        const int thigh = 50;

        public BodyRepo()
        {
            Table = Context.Params;
        }

        public int AddDailyParameters(Param bodyParam)
        {
            List<Param> list = Table.Where(prm => prm.Date == bodyParam.Date).ToList();

            if (list.Count ==0) return Add(bodyParam);
            else
            {
                var changingItem = GetOne(list[0].Id);
                changingItem.Weight = bodyParam.Weight;
                changingItem.Breast = bodyParam.Breast;
                changingItem.Waist = bodyParam.Waist;
                changingItem.Buttock = bodyParam.Buttock;
                changingItem.Thigh = bodyParam.Thigh;

                return Save(changingItem);
            }
        }

        public Param SelectDefaultParam()
        {
            return new Param { Weight = weight, Breast = breast, Buttock = buttock, Waist = waist, Thigh = thigh };
        }

        public Param SelectParam(DateTime date)
        {
            List<Param> param = Table.Where(prt => prt.Date == date).ToList();
            if (param.Count == 0) return SelectDefaultParam();
            else return param[0];
        }

        public Param SelectParam()
        {
            Param param = new Param();
            List<Param> listParam = (Table.Where(prt => prt.Weight != 0).ToList() as List<Param>);
            param.Weight = listParam.Count != 0 ? listParam[listParam.Count - 1].Weight : 0;

            listParam = (Table.Where(prt => prt.Breast != 0).ToList() as List<Param>);
            param.Breast = listParam.Count != 0 ? listParam[listParam.Count - 1].Breast : 0;

            listParam = (Table.Where(prt => prt.Breast != 0).ToList() as List<Param>);
            param.Waist = listParam.Count != 0 ? listParam[listParam.Count - 1].Waist : 0;

            listParam = (Table.Where(prt => prt.Breast != 0).ToList() as List<Param>);
            param.Buttock = listParam.Count != 0 ? listParam[listParam.Count - 1].Buttock : 0;

            listParam = (Table.Where(prt => prt.Breast != 0).ToList() as List<Param>);
            param.Thigh = listParam.Count != 0 ? listParam[listParam.Count - 1].Thigh : 0;

            return param;
        }
    }
}
