using HyperCompanyCase.Business.Abstract.Command;
using HyperCompanyCase.Business.Abstract.Query;
using HyperCompanyCase.Business.Abstract.Service;
using HyperCompanyCase.Business.Constants;
using HyperCompanyCase.Core.Utilities.Result;
using HyperCompanyCase.Entities.Entity;

namespace HyperCompanyCase.Business.Concrete.Service
{
    public class BoatService: IBoatService
    {
        private readonly IDynamicQuery _dynamicQuery;

        public BoatService(IDynamicQuery dynamicQuery)
        {
            _dynamicQuery = dynamicQuery;
        }

        public async Task<DataResult> GetBoatsByColorIdAsync(int colorId)
        {
            DataResult dataResult = new();

            Color color = await _dynamicQuery.GetAsync<Color>(colorId);

            if (color is null)
            {
                dataResult.ErrorMessageList.Add(GeneralMessages.ColorNotFound);
                return dataResult;
            }


            List<Boat> list = await _dynamicQuery.GetAllAsync<Boat>($"WHERE IsStatus=1 AND ColorId={colorId} ");

            if (list.Exists(x => x.IsStatus))
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
