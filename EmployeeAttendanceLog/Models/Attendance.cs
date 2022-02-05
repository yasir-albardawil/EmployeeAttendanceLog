using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAttendanceLog.Models
{
	public class Attendance
	{
		[Key]
		public int AttendanceId { get; set; }		

		public DateTime CehckIn { get; set; }

		public DateTime CheckOut { get; set;}	

		public string? Justification { get; set; }

	}
}
	