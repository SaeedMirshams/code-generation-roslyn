
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
     public void Configure(EntityTypeBuilder<Post> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
