namespace Todo.Infrastructure.Persistance.Entities
{
    internal class Tag: BaseAuditableEntity
    {
        public string Name { get; set; }
        public string ColorCode { get; set; }

        public ICollection<TodoItemTag> TodoItemTags { get; set; }
    }
}
