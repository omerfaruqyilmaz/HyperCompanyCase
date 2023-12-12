
using HyperCompanyCase.Core.Utilities.Result;

namespace HyperCompanyCase.Business.Abstract.Service
{
    public interface ICarService
    {
        Task<DataResult> GetCarsByColorIdAsync(int colorId);
        Task<DataResult> ToggleHeadlightsAsync (int carId,bool on);
        Task<DataResult> DeleteCarByIdAsync(int carId);
        Task<DataResult> GetAllCarListAsync();
    }
}
