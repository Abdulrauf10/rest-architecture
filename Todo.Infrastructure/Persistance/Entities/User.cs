namespace Todo.Infrastructure.Persistance.Entities
{
    public class User: BaseAuditableEntity
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
