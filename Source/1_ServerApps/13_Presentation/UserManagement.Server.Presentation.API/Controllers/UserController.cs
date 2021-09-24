using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Server.Core.Application.Interfaces.IServices;
using UserManagement.Shared.Models.ServicesDTOs._Shared;
using UserManagement.Shared.Models.ServicesDTOs.GetUserDetailsList;
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
		public async Task<IActionResult> Users(int page = 1, short pageSize = 10)
		{
			ResponsePagedList<GetUserList_Response> response = await _userService.GetUserList(page, pageSize);
			return Ok(response);
		}

		[HttpGet]
		public async Task<IActionResult> UserDetails(int page = 1, short pageSize = 10)
		{
			ResponsePagedList<GetUserDetailsList_Response> response = await _userService.GetUserDetailsList(page, pageSize);
			return Ok(response);
		}
	}
}
