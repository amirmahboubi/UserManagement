using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Domain.Entities;

namespace UserManagement.Server.Core.Domain.SeedData
{
	public static class UserSeedData
	{
		public static User[] GetUsers()
		{
			return new User[]
			{
				new User() 
				{
					UserId = 1,
					UserName = "Admin",
					Password = "admin*963",
					IsActive = true,
					FirstName = "Admin",
					LastName = "AdminZadeh",
					Mobile = "+989171112233"
				},
				new User()
				{
					UserId = 2,
					UserName = "a.mahboubi",
					Password = "amir*963",
					IsActive = true,
					FirstName = "Amir",
					LastName = "Mahboubi",
					Mobile = "+989227609862"
				},
				new User()
				{
					UserId = 3,
					UserName = "a.amini",
					Password = "amin*963",
					IsActive = false,
					FirstName = "Amin",
					LastName = "Amini",
					Mobile = "+989121112233"
				},
				new User()
				{
					UserId = 4,
					UserName = "a.amiri",
					Password = "amiri*963",
					IsActive = false,
					FirstName = "Amir",
					LastName = "Amiri",
					Mobile = "+989121112233"
				},
				new User()
				{
					UserId = 5,
					UserName = "m.minaee",
					Password = "mina*963",
					IsActive = true,
					FirstName = "Mina",
					LastName = "Minaee",
					Mobile = "+989121112233"
				},
			};
		}
	}
}
