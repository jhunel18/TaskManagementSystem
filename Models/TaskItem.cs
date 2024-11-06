
using System.ComponentModel.DataAnnotations;
namespace TaskManagementSystem.Models
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string Status { get; set; }
    }
}
