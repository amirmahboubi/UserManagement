using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Server.Core.Application.Interfaces.IServices;
using UserManagement.Shared.Models.ServicesDTOs._Shared;
using UserManagement.Shared.Models.ServicesDTOs.GetUserList;

namespace UserManagement.Server.Presentation.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet]
		public async Task<IActionResult> List(int pageNumber = 1, short pageSize = 10)
		{
			ResponsePagedList<GetUserList_Response> response = await _userService.GetUserList(pageNumber, pageSize);
			return Ok(response);
		}
	}
}
