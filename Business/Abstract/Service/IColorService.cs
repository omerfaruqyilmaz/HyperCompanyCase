using HyperCompanyCase.Core.Utilities.Result;

namespace HyperCompanyCase.Business.Abstract.Service
{
    public interface IColorService
    {
        Task<DataResult> GetAllColorAsync();

    }
}
