using Microsoft.AspNetCore.Mvc;
using PrototypeQ.Services.Abstractions.Services;

namespace PrototypeQ.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AliasController : ControllerBase
	{
		private readonly IAliasService _aliasService;

		public AliasController(IAliasService aliasService)
		{
			_aliasService = aliasService;
		}

		[HttpGet]
		[Route("{id}")]
		public IActionResult Get(int id)
		{
			return Ok(_aliasService.Get(id));
		}

		[HttpGet]
		[Route("All")]
		public IActionResult GetAll()
		{
			return Ok(_aliasService.GetAll());
		}

		[HttpPost]
		[Route("Create")]
		public IActionResult Create([FromBody] string name, [FromBody] string[] aliases)
		{
			_aliasService.Create(name, aliases);
			return Ok();
		}

		[HttpDelete]
		[Route("{id}")]
		public IActionResult Delete(int id)
		{
			_aliasService.Delete(id);
			return Ok();
		}

		[HttpPut]
		[Route("Update/{id}")]
		public IActionResult Update(int id, [FromBody] string name, [FromBody] string[] aliases)
		{
			_aliasService.Update(id, name, aliases);
			return Ok();
		}

		[HttpPut]
		[Route("AddToAliases/{id}")]
		public IActionResult AddToAliases(int id, [FromBody] string alias)
		{
			_aliasService.AddToAliases(id, alias);
			return Ok();
		}

		[HttpPut]
		[Route("RemoveFromAliases/{id}")]
		public IActionResult RemoveFromAliases(int id, [FromBody] string alias)
		{
			_aliasService.RemoveFromAliases(id, alias);
			return Ok();
		}
	}
}