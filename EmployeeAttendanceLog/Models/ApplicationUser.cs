using Microsoft.AspNetCore.Identity;

namespace EmployeeAttendanceLog.Models
{
    public class ApplicationUser : IdentityUser
    {
    
        public int IsAdmin { get; set; }
    }
}