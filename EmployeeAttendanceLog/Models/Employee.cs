using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAttendanceLog.Models
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }	
		public string Name { get; set; }
		//public List<Attendance> Attendances { get; set; }

		[ForeignKey("UserId")]
		public virtual ApplicationUser User { get; set; }
	}
}
