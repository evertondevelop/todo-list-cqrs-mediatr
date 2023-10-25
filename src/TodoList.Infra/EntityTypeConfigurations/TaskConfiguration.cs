using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task = TodoList.Domain.Entities.Task;

namespace TodoList.Data.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable("Task");

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(236);

            builder.Property(t => t.IsCompleted)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(t => t.DueDate)
                .IsRequired(false);
        }
    }
}