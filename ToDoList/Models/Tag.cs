namespace ToDoList.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Goal> Goal { get; set; }
    }
}
