using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Goal
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; } = null!;
        public string Notes { get; set; } = null!;// additional information
        public int Status { get; set; } // status of working condition done/in process/ not 
        public ICollection<Tag> Tags { get; set; }
    }
}
