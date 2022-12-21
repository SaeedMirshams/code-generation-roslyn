
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class CompetencyConfiguration : IEntityTypeConfiguration<Competency>
    {
     public void Configure(EntityTypeBuilder<Competency> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
