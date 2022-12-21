
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class DevelopmentProgramConfiguration : IEntityTypeConfiguration<DevelopmentProgram>
    {
     public void Configure(EntityTypeBuilder<DevelopmentProgram> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
