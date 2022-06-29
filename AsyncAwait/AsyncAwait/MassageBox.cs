using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class MassageBox
    {
        public event Action<State> WindowClosed;

        public async void Open()
        {
            Console.WriteLine("Window open");
            await Task.Run(() => Task.Delay(3000));
            Console.WriteLine("Window was closed by user");
            WindowClosed?.Invoke((State)new Random().Next(0, 2));
        }
    }
}
