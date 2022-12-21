
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class CompetencyCategoryConfiguration : IEntityTypeConfiguration<CompetencyCategory>
    {
     public void Configure(EntityTypeBuilder<CompetencyCategory> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
