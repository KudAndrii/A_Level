using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Interfaces
{
    internal interface IGarageCountService
    {
        public int CountCoast(ICar[] garage);
        public ICar[] SortByResourseConsumption(ICar[] garage);
    }
}
