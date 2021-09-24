using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Shared.Models.ServicesDTOs.GetUserList
{
	public class GetUserList_Response
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Mobile { get; set; }
		public bool IsActive { get; set; }
	}
}
