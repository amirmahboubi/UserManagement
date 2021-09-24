using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Domain.Entities;

namespace UserManagement.Server.Core.Domain.SeedData
{
	public static class UserDetailSeedData
	{
		public static UserDetail[] GetUsersDetails()
		{
			return new UserDetail[]
			{
				new UserDetail()
				{
					UserId = 1,
					UserDetailId = 1,
					Address = "Iran",
					BirthDate = DateTime.Now.Date.AddYears(-20),
					Email = "admin@admin.com"
				},
				new UserDetail()
				{
					UserId = 2,
					UserDetailId = 2,
					Address = "Shiraz",
					BirthDate = DateTime.Now.Date.AddYears(-26),
					Email = "AmirMahboubi@outlook.com"
				},
				new UserDetail()
				{
					UserId = 3,
					UserDetailId = 3,
					Address = "Tabriz",
					BirthDate = DateTime.Now.Date.AddYears(-29),
					Email = "Tabriz@admin.com"
				},
				new UserDetail()
				{
					UserId = 4,
					UserDetailId = 4,
					Address = "Tehran",
					BirthDate = DateTime.Now.Date.AddYears(-23),
					Email = "Tehran@admin.com"
				},
				new UserDetail()
				{
					UserId = 5,
					UserDetailId = 5,
					Address = "Shiraz",
					BirthDate = DateTime.Now.Date.AddYears(-28),
					Email = "Shiraz@admin.com"
				}
			};
		}
	}
}
