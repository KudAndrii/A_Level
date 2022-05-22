using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdatedLogger.Interfaces;
using UpdatedLogger.SpecialExceptions;
using UpdatedLogger.Logger;
using UpdatedLogger.Enums;

namespace UpdatedLogger.AppPricessing
{
    internal class Starter : IStarter
    {
        private Random _random;
        private IActions _actions;
        public Starter(IActions actions, Random random)
        {
            _actions = actions;
            _random = random;
        }

        public void Run()
        {
            bool flag = default;
            for (int i = 0; i < 100; i++)
            {
                int num = _random.Next(0, 3);
                try
                {
                    switch (num)
                    {
                        case 0:
                            flag = _actions.Start();
                            break;
                        case 1:
                            flag = _actions.Skipp();
                            break;
                        case 2:
                            flag = _actions.Broke();
                            break;
                    }
                }
                catch (BusinessException businessEsception)
                {
                    MyLogger.Instance.AddLog("Action got this custom Exception: ", LogType.Warning, businessEsception.Massage);
                }
                catch (Exception exception)
                {
                    MyLogger.Instance.AddLog("Action failed by a reason: ", LogType.Error, exception.Message);
                }
            }
        }
    }
}
