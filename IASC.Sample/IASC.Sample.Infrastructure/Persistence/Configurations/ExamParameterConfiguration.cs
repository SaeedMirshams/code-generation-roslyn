
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class ExamParameterConfiguration : IEntityTypeConfiguration<ExamParameter>
    {
     public void Configure(EntityTypeBuilder<ExamParameter> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
