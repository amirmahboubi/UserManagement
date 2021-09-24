using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Shared.Models.ServicesDTOs.GetUserList;

namespace UserManagement.Shared.Models.ServicesDTOs.GetUserDetailsList
{
	public class GetUserDetailsList_Response : GetUserList_Response
	{
		public string Mobile { get; set; }
		public string? Email { get; set; }
		public string? Address { get; set; }
		public DateTime? BirthDate { get; set; }
	}
}
