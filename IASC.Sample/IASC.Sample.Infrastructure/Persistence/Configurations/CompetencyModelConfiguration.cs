
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class CompetencyModelConfiguration : IEntityTypeConfiguration<CompetencyModel>
    {
     public void Configure(EntityTypeBuilder<CompetencyModel> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
