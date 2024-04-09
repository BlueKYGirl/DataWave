using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;

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
    }
}
