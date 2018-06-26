using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options): base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TodoItem>(ConfigureTodoItem);
        }
        private void ConfigureTodoItem(EntityTypeBuilder<TodoItem> builder)
        {
            builder.ToTable("TodoItem");
            builder.Property(ci => ci.Id)
                .ForSqlServerUseSequenceHiLo("todo_hilo");

            builder.Property(ci => ci.Title)
                .IsRequired(true)
                .HasMaxLength(200);
            builder.Property(ci => ci.IsDone)
                .IsRequired(false);

        }
    }
}
