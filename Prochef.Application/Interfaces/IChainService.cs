
using System.Collections.Generic;
using Prochef.Core.Dtos.Request.Chains;
using Prochef.Core.Dtos.Response;

namespace Prochef.Application.Interfaces
{
    public interface IChainService
    {
        IEnumerable<ChainResponse> GetAllChains();
        void DeleteChain(int chainId);
        int UpdateChain(UpsertChainRequest chainRequest, int chainId);
        int CreateChain(UpsertChainRequest chainRequest);

    }
}
