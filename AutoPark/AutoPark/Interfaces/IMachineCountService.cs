using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Interfaces
{
    public interface IMachineCountService
    {
        /// <summary>
        /// Method counts resourse consumption of car based on incoming data.
        /// </summary>
        /// <param name="body">Incoming type of body.</param>
        /// <param name="enginePower">Incoming engine power.</param>
        /// <returns>Resourse consumption.</returns>
        public int CountResourseConsumption(string body, int enginePower);

        /// <summary>
        /// Method counts coast of car base on incoming data.
        /// </summary>
        /// <param name="name">Types of car's manufacturers.</param>
        /// <param name="body">Types of car's bodys.</param>
        /// <param name="enginePower">Incoming engine power.</param>
        /// <returns>Car's coast.</returns>
        public int CountCoast(string name, string body, int enginePower);

        /// <summary>
        /// Method counts resourse volume of car based on incoming data.
        /// </summary>
        /// <param name="body">Types of car's bodys.</param>
        /// <param name="engine">Incoming engine.</param>
        /// <returns>Car's resourse volume.</returns>
        public int CountResourseVolume(string body, IEngine engine);
    }
}
