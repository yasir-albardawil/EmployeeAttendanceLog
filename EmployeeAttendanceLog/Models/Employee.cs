using System.ComponentModel.DataAnnotations;

namespace EmployeeAttendanceLog.Models
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }	
		public string Name { get; set; }
		public List<Attendance> Attendances { get; set; }
	}
}
