using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.web.Models
{
    public class EmployeeListVM
    {
        public string id { get; set; }

        [Display(Name ="First Name")]
        public string Firstname { get; set; }

        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Display(Name = "Date Joined")]
        public DateTime DateJoined { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
}
