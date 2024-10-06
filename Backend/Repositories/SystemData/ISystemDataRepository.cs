using Backend.Model.Entitys;

namespace Backend.Repositories.SystemData
{
    public interface ISystemDataRepository
    {
        Task AddSystemDataAsync(SystemDataEntity systemData);

        Task<List<SystemDataEntity>> GetAllSystemDataAsync();
    }
}
