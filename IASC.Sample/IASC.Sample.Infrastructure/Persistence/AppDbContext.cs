using IASC.Core.Entities;
using IASC.Core.EntityFrameworkCore;
using IASC.Sample.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IASC.Sample.Infrastructure.Persistence
{
    public class AppDbContext : IASCDbContext<AppDbContext>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options, AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor)
            : base(options, auditableEntitySaveChangesInterceptor)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Competency> Competencies { get; set; }
        public DbSet<CompetencyCategory> CompetencyCategories { get; set; }
        public DbSet<CompetencyModel> CompetencyModels { get; set; }
        public DbSet<EvaluationPeriod> EvaluationPeriods { get; set; }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamParameter> ExamParameters { get; set; }
        public DbSet<SuccessorRepository> SuccessorRepositories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Employee> Employees { get; set; }



        public DbSet<PostCompetency> PostCompetencies { get; set; }


        public DbSet<EvaluationResult> EvaluationResults { get; set; }


        public DbSet<ExamScore> ExamScores { get; set; }
        public DbSet<CompetencyScore> CompetencyScores { get; set; }

    }
}
