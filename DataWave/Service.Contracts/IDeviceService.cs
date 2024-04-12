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
        Task<IEnumerable<DeviceDto>> GetAllDevicesByPlanUserAsync(Guid planUserId, bool trackChanges);
        Task<IEnumerable<DeviceDto>> GetAllDevicesByUserAsync(Guid userId, bool trackChanges);
        DeviceDto GetDevice(Guid id, bool trackChanges);
        Task<DeviceDto> GetDeviceAsync(Guid id, bool trackChanges);
        Task<DeviceDto> GetDeviceByPhoneNumberAsync(string phoneNumber, bool trackChanges);
        Task<DeviceDto> CreateDeviceAsync(Guid userId,DeviceForCreationDto device);
        Task DeleteDeviceAsync(Guid id, bool trackChanges);
        Task<DeviceDto> UpdateDeviceAsync(Guid id, DeviceForUpdateDto device, bool trackChanges);
        Task<SwapPhoneNumberResponseDto> SwapPhoneNumberAsync(DeviceForUpdateDto device1, DeviceForUpdateDto device2, bool trackChanges);
        void DeleteDevice(Guid id, bool trackChanges);
        void UpdateDevice(Guid id, DeviceForUpdateDto device, bool trackChanges);
    }
}
