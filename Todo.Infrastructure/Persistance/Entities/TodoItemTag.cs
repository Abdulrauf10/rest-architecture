namespace Todo.Infrastructure.Persistance.Entities
{
    internal class TodoItemTag: BaseAuditableEntity
    {
        public Guid Id { get; set; }
        public Guid TodoItemId { get; set; }
        public TodoItem TodoItem { get; set; }

        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
}
