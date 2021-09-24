using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Application.Interfaces.IFeaturesQueries;
using UserManagement.Server.Core.Application.Interfaces.IServices;

namespace UserManagement.Server.Core.Application.Services
{
	public class AuthenticationService : IAuthenticationService
	{
		private readonly IUserQueryService _userQueryService;

		public AuthenticationService(IUserQueryService userQueryService)
		{
			_userQueryService = userQueryService;
		}
	}
}
