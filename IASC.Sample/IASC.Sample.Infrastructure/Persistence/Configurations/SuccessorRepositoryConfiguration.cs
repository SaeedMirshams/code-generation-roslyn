
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class SuccessorRepositoryConfiguration : IEntityTypeConfiguration<SuccessorRepository>
    {
     public void Configure(EntityTypeBuilder<SuccessorRepository> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
