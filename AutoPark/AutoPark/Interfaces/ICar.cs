using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Interfaces
{
    public interface ICar
    {
        public IEngine Engine { get; }
        public string Name { get; }
        public string Body { get; }
        public int Coast { get; }
        public void Move(int fuel);
    }
}
