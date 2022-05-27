using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Interfaces
{
    public interface ICountServices
    {
        public int CountResourseConsumption(string body, int enginePower);
        public int CountCoast(string name, string body, int enginePower);
        public int CountResourseVolume(string body, IEngine engine);
    }
}
