using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresRequests.Interfaces
{
    public interface IReqresClient
    {
        public Task<string> GetUsersList(int page);

    }
}
