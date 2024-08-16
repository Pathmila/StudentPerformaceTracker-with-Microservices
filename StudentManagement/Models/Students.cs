using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Students
    {
        [Key]
        public int StudentID { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
