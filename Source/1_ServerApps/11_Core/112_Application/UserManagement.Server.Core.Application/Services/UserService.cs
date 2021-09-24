using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Application.Interfaces.IFeaturesQueries;
using UserManagement.Server.Core.Application.Interfaces.IServices;
using UserManagement.Shared.Models.ServicesDTOs._Shared;
using UserManagement.Shared.Models.ServicesDTOs.GetUserList;

namespace UserManagement.Server.Core.Application.Services
{
	public class UserService : IUserService
	{
		private readonly IUserQueryService _userQueryService;

		public UserService(IUserQueryService userQueryService)
		{
			_userQueryService = userQueryService;
		}

		public async Task<ResponsePagedList<GetUserList_Response>> GetUserList(int pageNumber, short pageSize) =>
			await _userQueryService.GetUserList(pageNumber, pageSize);
	}
}
