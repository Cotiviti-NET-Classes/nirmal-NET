using System.ComponentModel.DataAnnotations;

namespace HRApp.Models
{
    public class Designation
    {
        [Key]
        public int DesignationID { get; set; }
        public string? DesignationName { get; set; }
        public int Salary { get; set; }
        public List<Employee>? Employees { get; set; }
    }
}
