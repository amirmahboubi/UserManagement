using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Shared.Models.ServicesDTOs._Shared
{
	public class ResponseList<TResponse> : Response
	{
		public List<TResponse> ContentList { get; set; }
	}
}
