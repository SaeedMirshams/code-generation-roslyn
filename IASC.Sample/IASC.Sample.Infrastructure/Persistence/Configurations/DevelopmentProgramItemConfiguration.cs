
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class DevelopmentProgramItemConfiguration : IEntityTypeConfiguration<DevelopmentProgramItem>
    {
     public void Configure(EntityTypeBuilder<DevelopmentProgramItem> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
