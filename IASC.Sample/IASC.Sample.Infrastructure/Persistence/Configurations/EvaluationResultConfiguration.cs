
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class EvaluationResultConfiguration : IEntityTypeConfiguration<EvaluationResult>
    {
     public void Configure(EntityTypeBuilder<EvaluationResult> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
