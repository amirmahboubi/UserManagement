namespace UserManagement.Server.Core.Domain.Entities
{
	public class UserDetail
	{
		public int UserDetailId { get; set; }
		public string? Email { get; set; }
		public string? Address { get; set; }
		public DateTime? BirthDate { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }
	}
}
