using EVEMorgue.Infrastructure.DTO;
using EVEMorgue.Infrastructure.RepositoriesContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EVEMorgue.Infrastructure.Repositories
{
    internal class EsiRepo : IEsiRepo
    {
        public Task<IReadOnlyList<int>> GetAllCategoryIdsAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<int>> GetAllGroupIdsAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<int>> GetAllTypeIdsAsync(int page = 1, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<EsiCategoryDto> GetCategoryByIdAsync(int categoryId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<EsiGroupDto> GetGroupByIdAsync(int groupId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<EsiTypeDto> GetTypeByIdAsync(int typeId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<EsiTypeDto>> GetTypesByIdsAsync(IEnumerable<int> typeIds, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
