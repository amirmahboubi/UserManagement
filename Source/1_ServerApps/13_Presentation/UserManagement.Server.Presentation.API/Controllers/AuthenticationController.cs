using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Server.Core.Application.Interfaces.IServices;

namespace UserManagement.Server.Presentation.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthenticationController : ControllerBase
	{
		private readonly IAuthenticationService _authenticationService;

		public AuthenticationController(IAuthenticationService authenticationService)
		{
			_authenticationService = authenticationService;
		}
	}
}
