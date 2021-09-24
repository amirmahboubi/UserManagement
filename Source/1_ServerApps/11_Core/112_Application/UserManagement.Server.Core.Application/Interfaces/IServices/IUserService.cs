using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Shared.Models.ServicesDTOs._Shared;
using UserManagement.Shared.Models.ServicesDTOs.GetUserList;

namespace UserManagement.Server.Core.Application.Interfaces.IServices
{
	public interface IUserService
	{
		Task<ResponsePagedList<GetUserList_Response>> GetUserList(int pageNumber, short pageSize);
	}
}
