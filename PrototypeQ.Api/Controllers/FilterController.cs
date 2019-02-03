using Microsoft.AspNetCore.Mvc;
using PrototypeQ.DataAccess.Entities;
using PrototypeQ.Services.Abstractions.Services;

namespace PrototypeQ.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FilterController : ControllerBase
	{
		private readonly IFilterService _filterService;

		public FilterController(IFilterService filterService)
		{
			_filterService = filterService;
		}

		public IActionResult GetPersonFilterInfo()
		{
			return Ok(_filterService.GetAvailableFilters(typeof(PersonEntity)));
		}
	}
}