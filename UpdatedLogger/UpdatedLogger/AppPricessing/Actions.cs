using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdatedLogger.Interfaces;
using UpdatedLogger.Logger;
using UpdatedLogger.Enums;
using UpdatedLogger.SpecialExceptions;

namespace UpdatedLogger.AppPricessing
{
    internal class Actions : IActions
    {
        private IMyLogger _logger;
        public Actions(IMyLogger logger)
        {
            _logger = logger;
        }

        public bool Start()
        {
            _logger.AddLog($"Start method: {nameof(Start)}", LogType.Info);
            return true;
        }

        public bool Skip()
        {
            throw new BusinessException("Skipped logic in method");
        }

        public bool Broke()
        {
            throw new Exception("I broke a logic");
        }
    }
}
