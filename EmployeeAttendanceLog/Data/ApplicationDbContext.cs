using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EmployeeAttendanceLog.Models;

namespace EmployeeAttendanceLog.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<EmployeeAttendanceLog.Models.Employee> Employee { get; set; }

		public DbSet<EmployeeAttendanceLog.Models.Attendance> Attendance { get; set; }
	}
}