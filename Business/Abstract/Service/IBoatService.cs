using HyperCompanyCase.Core.Utilities.Result;

namespace HyperCompanyCase.Business.Abstract.Service
{
    public interface IBoatService
    {
        Task<DataResult> GetBoatsByColorIdAsync(int colorId);

    }
}
