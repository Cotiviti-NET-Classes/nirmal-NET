using System.ComponentModel.DataAnnotations;

namespace HRApp.Models
{
    public class Employee
    {
        [Key]
        public int EId { get; set; }
        public string? EName { get; set; }
        public string? EContact { get; set; }
        public DateTime EJoined { get; set; }
       public string? EAddress { get; set; }
        public int DepartmentID { get; set; }
        public Department? Department { get; set; }
        public int DesignationID { get; set; }
        public Designation? Designation { get; set; }
    }
    
}
