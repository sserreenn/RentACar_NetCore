using Application.Features.Models.Models;
using Application.Features.Models.Queries.GetListModel;
using Application.Features.Models.Queries.GetListModelByDynamic;
using Core.Application.Requests;
using Core.Persistence.Dynamic;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[conroller]")]
    [ApiController]

    public class ModelsController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListModelQuery getlistModelQuery = new GetListModelQuery { PageRequest = pageRequest };
            ModelListModel result = await Mediator.Send(getlistModelQuery);
            return Ok(result);
        }
        [HttpPost("GetList/ByDynamic")]
        public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] Dynamic dynamic)
        {
            GetListModelDynamicQuery getListModelDynamicQuery = new GetListModelDynamicQuery { PageRequest = pageRequest, dynamic = dynamic };
            ModelListModel result = await Mediator.Send(getListModelDynamicQuery);
            return Ok(result);
        }
    }
}