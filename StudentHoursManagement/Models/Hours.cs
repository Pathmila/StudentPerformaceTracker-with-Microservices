using System.ComponentModel.DataAnnotations;

namespace StudentHoursManagement.Models
{
    public class Hours
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Subject { get; set; }
        public int StudyHours { get; set; }
        public int BreakHours { get; set; }
    }
}
