
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class EvaluationPeriodConfiguration : IEntityTypeConfiguration<EvaluationPeriod>
    {
     public void Configure(EntityTypeBuilder<EvaluationPeriod> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
