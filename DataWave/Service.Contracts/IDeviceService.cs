using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IDeviceService
    {
        Task<IEnumerable<DeviceDto>> GetAllDevicesAsync(bool trackChanges);
        DeviceDto GetDevice(Guid id, bool trackChanges);
        Task<DeviceDto> GetDeviceAsync(Guid id, bool trackChanges);
        Task<DeviceDto> CreateDeviceAsync(Guid userId,DeviceForCreationDto device);
    }
}
