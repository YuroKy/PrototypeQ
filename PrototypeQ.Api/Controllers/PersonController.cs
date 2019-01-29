using Microsoft.AspNetCore.Mvc;
using PrototypeQ.Services.Services.Abstractions;

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

		public IActionResult GetAll()
		{
			return Ok(_personService.GetAll());
		}
	}
}