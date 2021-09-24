using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Shared.Models.ServicesDTOs._Shared
{
	public class ResponseBase<TResponse> : Response
	{
		public TResponse ContentData { get; set; }
	}
}
