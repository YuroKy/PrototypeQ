using Microsoft.AspNetCore.Mvc;
using PrototypeQ.Data.Entities;
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

		[HttpGet]
		[Route("PersonFilters")]
		public IActionResult GetPersonFilterInfo()
		{
			return Ok(_filterService.GetAvailableFilters(typeof(PersonEntity)));
		}
	}
}