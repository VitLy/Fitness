using System.Collections.Generic;

namespace DomainLayer.Model
{
    public partial class Param
    {
        public List<decimal> ToList()
        {
            List<decimal> list = new List<decimal> { (decimal)Weight, Breast, Buttock, Waist, Thigh };
            return list;
        }
    }
}
