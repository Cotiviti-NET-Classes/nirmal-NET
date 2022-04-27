using System.ComponentModel.DataAnnotations;

namespace HRApp.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string? DepartmentName { get; set; }
        public List<Employee>? Employees { get; set; }
    }
}
