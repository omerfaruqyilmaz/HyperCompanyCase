using HyperCompanyCase.Business.Abstract.Query;
using HyperCompanyCase.Business.Abstract.Service;
using HyperCompanyCase.Business.Constants;
using HyperCompanyCase.Core.Utilities.Result;
using HyperCompanyCase.Entities.Entity;

namespace HyperCompanyCase.Business.Concrete.Service
{
    public class ColorService : IColorService
    {
        private readonly IDynamicQuery _dynamicQuery;

        public ColorService(IDynamicQuery dynamicQuery)
        {
            _dynamicQuery = dynamicQuery;
        }

        public async Task<DataResult> GetAllColorAsync()
        {
            DataResult dataResult = new();

            List<Color> list = await _dynamicQuery.GetAllAsync<Color>("");

            if (list.Any())
            {
                dataResult.Data = list.Select(b => new
                {
                    b.Id,
                    b.Name
                });

                dataResult.Total = list.Count;
                return dataResult;

            }

            dataResult.ErrorMessageList.Add(GeneralMessages.ResultNotFound);
            return dataResult;

        }
    }
}
