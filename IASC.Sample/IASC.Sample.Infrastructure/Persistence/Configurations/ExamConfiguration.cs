
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
     public void Configure(EntityTypeBuilder<Exam> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
