using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Infrastructure.Persistance.Entities
{
    public class TodoAppDbContext : DbContext
    {
        public TodoAppDbContext(DbContextOptions<TodoAppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoItemTag> TodoItemsTags { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }

    }
}
