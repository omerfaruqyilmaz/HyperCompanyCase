using HyperCompanyCase.Business.Abstract.Service;
using HyperCompanyCase.Core.Utilities.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HyperCompanyCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly IColorService _colorService;
        public ColorController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet]
        [Route("get-all-color")]
        public async Task<IActionResult> GetAllColorAsync()
        {
            DataResult dataResult = await _colorService.GetAllColorAsync();
            return dataResult.HttpResponse();
        }
    }
}
