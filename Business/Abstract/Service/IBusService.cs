using HyperCompanyCase.Core.Utilities.Result;

namespace HyperCompanyCase.Business.Abstract.Service
{
    public interface IBusService
    {
        Task<DataResult> GetBusesByColorIdAsync(int colorId);
    }
}
