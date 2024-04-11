using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;
using Entities;
using Entities.Exceptions;

namespace Service
{
    public class DeviceService : IDeviceService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public DeviceService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DeviceDto>> GetAllDevicesAsync(bool trackChanges)
        {
            var devices = await _repositoryManager.Device.GetAllDevicesAsync(trackChanges);
            var devicesDto = _mapper.Map<IEnumerable<DeviceDto>>(devices);
            return devicesDto;
        }
        public DeviceDto GetDevice(Guid id, bool trackChanges)
        {
            var device = _repositoryManager.Device.GetDevice(id, trackChanges);
            var deviceDto = _mapper.Map<DeviceDto>(device);
            return deviceDto;
        }
        public async Task<DeviceDto> GetDeviceAsync(Guid id, bool trackChanges)
        {
            var device = await _repositoryManager.Device.GetDeviceAsync(id, trackChanges);
            var deviceDto = _mapper.Map<DeviceDto>(device);
            return deviceDto;
        }
        public async Task<DeviceDto> CreateDeviceAsync(Guid userId, DeviceForCreationDto device)
        {
            var deviceEntity = _mapper.Map<Device>(device);
            deviceEntity.UserId = userId;
            _repositoryManager.Device.CreateDevice(deviceEntity);
            await _repositoryManager.SaveAsync();
            var deviceToReturn = _mapper.Map<DeviceDto>(deviceEntity);
            return deviceToReturn;
        }
        public void DeleteDevice(Guid id, bool trackChanges)
        {
            var device = _repositoryManager.Device.GetDevice(id, trackChanges);
            if (device == null)
                throw new DeviceNotFoundException(id);
                
            _repositoryManager.Device.DeleteDevice(device);
            _repositoryManager.Save();
        }
        public async Task DeleteDeviceAsync(Guid id, bool trackChanges)
        {
            var device = await _repositoryManager.Device.GetDeviceAsync(id, trackChanges);
            if (device == null)
                throw new DeviceNotFoundException(id);
                
              
            _repositoryManager.Device.DeleteDevice(device);
            await _repositoryManager.SaveAsync();
        }
        public void UpdateDevice(Guid id, DeviceForUpdateDto device, bool trackChanges)
        {
            var deviceEntity = _repositoryManager.Device.GetDevice(id, trackChanges);
            if (deviceEntity == null)
                throw new DeviceNotFoundException(id);
                
            _mapper.Map(device, deviceEntity);
            _repositoryManager.Save();
        }
        public async Task<DeviceDto> UpdateDeviceAsync(Guid deviceId, DeviceForUpdateDto deviceUpdateDto, bool trackChanges)
        {
            var deviceEntity = await _repositoryManager.Device.GetDeviceAsync(deviceId, trackChanges);

            if (deviceEntity == null)
            {
                // Device with the specified ID not found
                throw new DeviceNotFoundException(deviceId);
            }

            // Update device properties based on the provided update DTO
            if (!string.IsNullOrEmpty(deviceUpdateDto.PhoneNumber))
            {
                deviceEntity.PhoneNumber = deviceUpdateDto.PhoneNumber;
            }

            if (deviceUpdateDto.PlanUserId != null)
            {
                deviceEntity.PlanUserId = deviceUpdateDto.PlanUserId;
            }

            // Save the updated device entity
            await _repositoryManager.SaveAsync();

            // Map the updated device entity to a DTO and return it
            var deviceToReturn = _mapper.Map<DeviceDto>(deviceEntity);
            return deviceToReturn;
        }




    }
}
