
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class PostCompetencyConfiguration : IEntityTypeConfiguration<PostCompetency>
    {
     public void Configure(EntityTypeBuilder<PostCompetency> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
