using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Application.Interfaces.IFeaturesQueries;
using UserManagement.Server.Core.Application.Interfaces.IServices;
using UserManagement.Shared.Models.ServicesDTOs._Shared;
using UserManagement.Shared.Models.ServicesDTOs.GetUserDetailsList;
using UserManagement.Shared.Models.ServicesDTOs.GetUserList;

namespace UserManagement.Server.Core.Application.Services
{
	public class UserService : IUserService
	{
		private readonly IUserQueryService _userQueryService;
		private readonly IUserDetailQueryService _userDetailQueryService;

		public UserService(IUserQueryService userQueryService, IUserDetailQueryService userDetailQueryService)
		{
			_userQueryService = userQueryService;
			_userDetailQueryService = userDetailQueryService;
		}

		public async Task<ResponsePagedList<GetUserList_Response>> GetUserList(int pageNumber, short pageSize) =>
			await _userQueryService.GetUserList(pageNumber, pageSize);

		public async Task<ResponsePagedList<GetUserDetailsList_Response>> GetUserDetailsList(int pageNumber, short pageSize) =>
			await _userDetailQueryService.GetUserDetailsList(pageNumber, pageSize);
	}
}
