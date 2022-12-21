
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class ExamScoreConfiguration : IEntityTypeConfiguration<ExamScore>
    {
     public void Configure(EntityTypeBuilder<ExamScore> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
