using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Shared.Models.ServicesDTOs._Shared;
using UserManagement.Shared.Models.ServicesDTOs.GetUserDetailsList;

namespace UserManagement.Server.Core.Application.Interfaces.IFeaturesQueries
{
	public interface IUserDetailQueryService
	{
		Task<ResponsePagedList<GetUserDetailsList_Response>> GetUserDetailsList(int pageNumber, short pageSize);
	}
}
