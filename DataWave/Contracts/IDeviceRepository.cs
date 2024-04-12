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
        Task<IEnumerable<Device>> GetAllDevicesByPlanUserAsync(Guid planUserId, bool trackchanges);
        Task<IEnumerable<Device>> GetAllDevicesByUserAsync(Guid userId, bool trackchanges);
        Task<Device> GetDeviceAsync(Guid id, bool trackChanges);
        Task<Device> GetDeviceByPhoneNumberAsync(string phoneNumber, bool trackChanges);
        Device GetDevice(Guid id, bool trackChanges);
        void CreateDevice(Device device);
        void DeleteDevice(Device device);
    }
}
