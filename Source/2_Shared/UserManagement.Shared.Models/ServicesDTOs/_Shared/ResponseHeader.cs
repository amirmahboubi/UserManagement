using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Shared.Models.ServicesDTOs._Shared
{
	public class ResponseHeader
	{
		public bool Succeeded { get; set; }
		public string Message { get; set; }
		public HttpStatusCode StatusCode { get; set; }
		public List<string> Errors { get; set; }
	}
}
