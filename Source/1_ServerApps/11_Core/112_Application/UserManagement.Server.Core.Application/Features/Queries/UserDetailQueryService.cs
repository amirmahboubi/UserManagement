using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Application.Helpers;
using UserManagement.Server.Core.Application.Interfaces.IFeaturesQueries;
using UserManagement.Server.Core.Application.Interfaces.IPersistenceRepositories;
using UserManagement.Shared.Models.ServicesDTOs._Shared;
using UserManagement.Shared.Models.ServicesDTOs.GetUserDetailsList;

namespace UserManagement.Server.Core.Application.Features.Queries
{
	public class UserDetailQueryService	: IUserDetailQueryService
	{
		private IUserDetailRepositoryAsync _userDetailRepository;

		public UserDetailQueryService(IUserDetailRepositoryAsync userDetailRepository)
		{
			_userDetailRepository = userDetailRepository;
		}

		public async Task<ResponsePagedList<GetUserDetailsList_Response>> GetUserDetailsList(int pageNumber, short pageSize)
		{
			ResponsePagedList<GetUserDetailsList_Response> response = new ResponsePagedList<GetUserDetailsList_Response>();
			try
			{
				var users = await _userDetailRepository.GetPagedUserDetailsAsync(pageNumber, pageSize);
				IEnumerable<GetUserDetailsList_Response> userList = users.Select(u => new GetUserDetailsList_Response()
				{
					UserId = u.UserId,
					Mobile = u.Mobile,
					IsActive = u.IsActive,
					LastName = u.LastName,
					UserName = u.UserName,
					Email = u.Detail?.Email,
					FirstName = u.FirstName,
					Address = u.Detail?.Address,
					BirthDate = u.Detail?.BirthDate
				});
				response = new ResponsePagedList<GetUserDetailsList_Response>()
				{
					ContentData = new PagedList<GetUserDetailsList_Response>()
					{
						ResultList = userList.ToList(),
						PageNumber = pageNumber,
						PageSize = pageSize,
						TotalCount = await _userDetailRepository.GetTotalCountAsync()
					},
					Header = ResponseHeaderHelperMethods.SuccessResponse()
				};
			}
			catch (Exception ex)
			{
				response = new ResponsePagedList<GetUserDetailsList_Response>()
				{
					ContentData = null,
					Header = ResponseHeaderHelperMethods.ExceptionResponse(exception: ex)
				};
			}
			return response;
		}
	}
}
