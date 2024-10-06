using AutoMapper;
using Backend.Model.DTO;
using Backend.Model.Entitys;
using Backend.Repositories.SystemData;

namespace Backend.Services
{
    public class SystemDataService
    {
        private readonly ISystemDataRepository _repository;
        private readonly IMapper _mapper;

        public SystemDataService(ISystemDataRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<SystemDataDto>> GetAllSystemData()
        {
            var systemData = await _repository.GetAllSystemDataAsync();
            return _mapper.Map<List<SystemDataDto>>(systemData);
        }

        public async Task SaveSystemData(SystemDataDto systemDataDto)
        {
            var systemData = _mapper.Map<SystemDataEntity>(systemDataDto);
            await _repository.AddSystemDataAsync(systemData);
        }
    }
}
