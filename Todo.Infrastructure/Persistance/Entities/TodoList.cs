namespace Todo.Infrastructure.Persistance.Entities
{
    internal class TodoList: BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
        public ICollection<TodoItem> TodoItems { get; set; }
    }
}
