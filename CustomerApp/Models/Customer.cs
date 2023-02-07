using System;
namespace CustomerApp.Models
{
	public class Customer
	{
		public string Name { get; set; } = string.Empty;
		public DateTime DateOfBirth { get; set; }
		public string Gender { get; set; } = string.Empty;
	}
}
