using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivselappen.ServiceAgents.Mocks
{
    public class MockDeviceServiceAgent : IDeviceServiceAgent
    {
        public async Task<bool> RegisterDeviceAsync(Models.Device device)
        {
            return true;
        }
    }
}
