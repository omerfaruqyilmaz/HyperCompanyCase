using HyperCompanyCase.Business.Abstract.Command;
using HyperCompanyCase.Business.Abstract.Query;
using HyperCompanyCase.Business.Abstract.Service;
using HyperCompanyCase.Business.Constants;
using HyperCompanyCase.Core.Utilities.Result;
using HyperCompanyCase.Entities.Entity;

namespace HyperCompanyCase.Business.Concrete.Service
{
    public class CarService : ICarService
    {
        private readonly IDynamicQuery _dynamicQuery;
        private readonly IDynamicCommandRepository _dynamicCommand;

        public CarService(IDynamicQuery dynamicQuery, IDynamicCommandRepository dynamicCommand)
        {
            _dynamicQuery = dynamicQuery;
            _dynamicCommand = dynamicCommand;
        }

        public async Task<DataResult> DeleteCarByIdAsync(int carId)
        {
            DataResult dataResult = new();

            Car car = await _dynamicQuery.GetAsync<Car>(carId);

            if (car is null)
            {
                dataResult.ErrorMessageList.Add(GeneralMessages.CarNotFound);
                return dataResult;
            }

            //car.IsStatus = false;

            //int exec = await _dynamicCommand.UpdateAsync(car); // Pasife alma 
            int exec = await _dynamicCommand.HardDeleteAsync<Car>(carId); //Tamamen silme

            if (exec > 0)
            {
                dataResult.Data = GeneralMessages.CarDeleted;
                return dataResult;
            }

            dataResult.ErrorMessageList.Add(GeneralMessages.CarDeletedFail);
            return dataResult;

        }

        public async Task<DataResult> GetAllCarListAsync()
        {
            DataResult dataResult = new();

           
            List<Car> list = await _dynamicQuery.GetAllAsync<Car>($"WHERE IsStatus=1 ORDER BY CreatedAt DESC ");

            if (list.Exists(x => x.IsStatus))
            {
                dataResult.Data = list.Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.Wheel,
                    c.HeadLigths
                });

                dataResult.Total = list.Count;
            }

            return dataResult;
        }

        public async Task<DataResult> GetCarsByColorIdAsync(int colorId)
        {
            DataResult dataResult = new();

            Color color =  await _dynamicQuery.GetAsync<Color>(colorId);

            if (color is null)
            {
                dataResult.ErrorMessageList.Add(GeneralMessages.ColorNotFound);
                return dataResult;
            }


            List<Car> list = await _dynamicQuery.GetAllAsync<Car>($"WHERE IsStatus=1 AND ColorId={colorId} ");

            if (list.Exists(x=>x.IsStatus))
            {
                dataResult.Data = list.Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.Wheel,
                    c.HeadLigths
                });

                dataResult.Total = list.Count;
                return dataResult;

            }

            dataResult.ErrorMessageList.Add(GeneralMessages.ResultNotFound);
            return dataResult;
        }

        public async Task<DataResult> ToggleHeadlightsAsync (int id,bool on)
        {
            DataResult dataResult = new();

            Car car = await _dynamicQuery.GetAsync<Car>(id);

            if (car is null) 
            {
                dataResult.ErrorMessageList.Add(GeneralMessages.CarNotFound);
                return dataResult;
            }

            car.HeadLigths = on;

            int exec = await _dynamicCommand.UpdateAsync(car);

            if (exec > 0) 
            {
                dataResult.Data = GeneralMessages.CarHeadligthUpdated;
                return dataResult;
            }

            dataResult.ErrorMessageList.Add(GeneralMessages.TransactionFailed);
            return dataResult;

        }
    }
}
