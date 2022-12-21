
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class CompetencyScoreConfiguration : IEntityTypeConfiguration<CompetencyScore>
    {
     public void Configure(EntityTypeBuilder<CompetencyScore> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
