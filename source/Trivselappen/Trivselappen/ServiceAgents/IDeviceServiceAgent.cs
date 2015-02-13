using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivselappen.Models;

namespace Trivselappen.ServiceAgents
{
    public interface IDeviceServiceAgent
    {
        Task<bool> RegisterDeviceAsync(Device device);
    }
}
