using Microsoft.AspNetCore.Mvc;
using PrototypeQ.Data.Models;
using PrototypeQ.Services.Abstractions.Services;

namespace PrototypeQ.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
	{
		private readonly IPersonService _personService;

		public PersonController(IPersonService personService)
		{
			_personService = personService;
		}

		[HttpGet]
		[Route("All")]
		public IActionResult GetAll()
		{
			return Ok(_personService.GetAll());
		}

		[HttpDelete]
		[Route("{id}")]
		public IActionResult Delete(int id)
		{
			_personService.Delete(id);
			return Ok();
		}

		[HttpPost]
		[Route("Create")]
		public IActionResult Create([FromBody] PersonModel model)
		{
			_personService.Create(model);
			return Ok();
		}
	}
}