using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Application.Helpers;
using UserManagement.Server.Core.Application.Interfaces.IFeaturesQueries;
using UserManagement.Server.Core.Application.Interfaces.IPersistenceRepositories;
using UserManagement.Server.Core.Domain.Entities;
using UserManagement.Shared.Models.ServicesDTOs._Shared;
using UserManagement.Shared.Models.ServicesDTOs.GetUserList;

namespace UserManagement.Server.Core.Application.Features.Queries
{
	public class UserQueryService : IUserQueryService
	{
		private IUserRepositoryAsync _userRepositoryAsync;

		public UserQueryService(IUserRepositoryAsync userRepositoryAsync)
		{
			_userRepositoryAsync = userRepositoryAsync;
		}

		public async Task<ResponsePagedList<GetUserList_Response>> GetUserList(int pageNumber, short pageSize)
		{
			ResponsePagedList<GetUserList_Response> response = new ResponsePagedList<GetUserList_Response>();
			try
			{
				var users = await _userRepositoryAsync.GetPagedReponseAsync(pageNumber, pageSize);
				IEnumerable<GetUserList_Response> userList = users.Select(u => new GetUserList_Response()
				{
					UserId = u.UserId,
					IsActive = u.IsActive,
					LastName = u.LastName,
					UserName = u.UserName,
					FirstName = u.FirstName,
				});
				response = new ResponsePagedList<GetUserList_Response>()
				{
					ContentData = new PagedList<GetUserList_Response>()
					{
						PageSize = pageSize,
						PageNumber = pageNumber,
						ResultList = userList.ToList(),
						TotalCount = await _userRepositoryAsync.GetTotalCountAsync()
					},
					Header = ResponseHeaderHelperMethods.SuccessResponse()
				};
			}
			catch (Exception ex)
			{
				response = new ResponsePagedList<GetUserList_Response>()
				{
					ContentData = null,
					Header = ResponseHeaderHelperMethods.ExceptionResponse(exception: ex)
				};
			}
			return response;
		}
	}
}
