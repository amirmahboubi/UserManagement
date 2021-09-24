using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Shared.Models.ServicesDTOs._Shared
{
	public class PagedList<TResponse>
	{
		public List<TResponse> ResultList { get; set; }
		public int PageNumber { get; set; }
		public short PageSize { get; set; }
		public long TotalCount { get; set; }
	}
}
