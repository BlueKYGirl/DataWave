using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IDeviceRepository
    {
        Task<IEnumerable<Device>> GetAllDevicesAsync(bool trackChanges);
        Task<Device> GetDeviceAsync(Guid id, bool trackChanges);
        Device GetDevice(Guid id, bool trackChanges);
        void CreateDevice(Device device);
        void DeleteDevice(Device device);
    }
}
