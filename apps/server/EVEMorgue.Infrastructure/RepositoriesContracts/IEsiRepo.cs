using EVEMorgue.Infrastructure.DTO;

namespace EVEMorgue.Infrastructure.RepositoriesContracts
{
    public interface IEsiTypesRepo
    {
        Task<IReadOnlyList<int>> GetAllTypeIdsAsync(int page = 1, CancellationToken cancellationToken = default);
        Task<EsiTypeDto> GetTypeByIdAsync(int typeId, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<EsiTypeDto>> GetTypesByIdsAsync(IEnumerable<int> typeIds, CancellationToken cancellationToken = default);
    }

    public interface IEsiGroupsRepo
    {
        Task<IReadOnlyList<int>> GetAllGroupIdsAsync(CancellationToken cancellationToken = default);
        Task<EsiGroupDto> GetGroupByIdAsync(int groupId, CancellationToken cancellationToken = default);
    }

    public interface IEsiCategoriesRepo
    {
        Task<IReadOnlyList<int>> GetAllCategoryIdsAsync(CancellationToken cancellationToken = default);
        Task<EsiCategoryDto> GetCategoryByIdAsync(int categoryId, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// Aggregate interface for scenarios that need access to all ESI universe endpoints.
    /// </summary>
    public interface IEsiRepo : IEsiTypesRepo, IEsiGroupsRepo, IEsiCategoriesRepo;
}