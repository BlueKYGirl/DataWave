using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;


namespace Repository
{
    public class DeviceRepository : RepositoryBase<Device>, IDeviceRepository
    {
        public DeviceRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public async Task<IEnumerable<Device>> GetAllDevicesAsync(bool trackchanges) =>
            await FindAll(trackchanges)
            .OrderBy(d => d.PlanUser)
            .ToListAsync();
        public Device GetDevice(Guid deviceId, bool trackChanges) =>
            FindByCondition(d => d.Id.Equals(deviceId), trackChanges)
            .SingleOrDefault();
        public async Task<Device> GetDeviceAsync(Guid deviceId, bool trackChanges) =>
            await FindByCondition(d => d.Id.Equals(deviceId), trackChanges)
            .SingleOrDefaultAsync();
        public void CreateDevice(Device device) => Create(device);
    }
}
