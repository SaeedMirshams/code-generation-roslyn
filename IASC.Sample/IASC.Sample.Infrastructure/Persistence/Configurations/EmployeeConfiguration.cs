
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Infrastructure.Persistence.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
     public void Configure(EntityTypeBuilder<Employee> builder)
     {
         //builder.Property(t => t.Code).IsRequired();
     }
    }
