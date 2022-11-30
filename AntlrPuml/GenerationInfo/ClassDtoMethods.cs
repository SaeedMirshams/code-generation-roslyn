namespace iasco.puml;
public partial class ClassDto
{
    internal void GenerateEntity()
    {
        var folderName = NameSpace + ".Domain\\Entities";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\" + Name + ".cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);
        csFile.WriteLine("using IASC.Core.Entities;");
        csFile.WriteLine("namespace " + NameSpace + ".Domain.Entities");
        csFile.WriteLine("{");
        csFile.WriteLine("    public class " + Name + " : Entity<" + Name + "IdType>");
        csFile.WriteLine("    {");
        foreach (var field in fields)
        {
            csFile.WriteLine($"        {field.AccessModifier} {field.FieldType}  {field.Name} " + "{ get; set; }");

        }
        csFile.WriteLine("");
        csFile.WriteLine("    }");
        csFile.WriteLine("}");

        csFile.Flush();
        csFile.Close();
        csFile.Dispose();

    }

    internal void GenerateBriefDtos()
    {
        var folderName = NameSpace + ".Application\\Contracts\\DTOs";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\" + Name + "BriefDto.cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);
        csFile.WriteLine("");

        csFile.WriteLine("using IASC.Core.Application.DTOs;");
        csFile.WriteLine("using IASC.Core.Application.Mappings;");
        csFile.WriteLine($"using {NameSpace}.Domain.Entities;");

        csFile.WriteLine("namespace " + NameSpace + ".Application.DTOs;\r\n");

        csFile.WriteLine($"public class {Name}BriefDto : EntityDto<{Name}IdType>,IMapFrom<{Name}>");
        csFile.WriteLine("    {");
        csFile.WriteLine("    }");

        csFile.Flush();
        csFile.Close();
        csFile.Dispose();

    }

    internal void GenerateDtos()
    {
        var folderName = NameSpace + ".Application\\Contracts\\DTOs";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\" + Name + "Dto.cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);
        csFile.WriteLine("");

        csFile.WriteLine("using IASC.Core.Application.DTOs;");
        csFile.WriteLine("using IASC.Core.Application.Mappings;");
        csFile.WriteLine($"using {NameSpace}.Domain.Entities;");

        csFile.WriteLine("namespace " + NameSpace + ".Application.DTOs\r\n");
        csFile.WriteLine("{");

        csFile.WriteLine($"public class {Name}Dto : EntityDto<{Name}IdType>,IMapFrom<{Name}>");
        csFile.WriteLine("    {");
        csFile.WriteLine("    }");
        csFile.WriteLine("}");

        csFile.Flush();
        csFile.Close();
        csFile.Dispose();

    }

    internal void GenerateConfigurations()
    {
        var folderName = NameSpace + ".Infrastructure\\Persistence\\Configurations";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\" + Name + "Configuration.cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);
        csFile.WriteLine("");

        csFile.WriteLine("using Microsoft.EntityFrameworkCore;");
        csFile.WriteLine("using Microsoft.EntityFrameworkCore.Metadata.Builders;");
        csFile.WriteLine($"using {NameSpace}.Domain.Entities;");

        csFile.WriteLine($"namespace {NameSpace}.Infrastructure.Persistence.Configurations;\r\n");

        csFile.WriteLine($"public class {Name}Configuration : IEntityTypeConfiguration<{Name}>");
        csFile.WriteLine("    {");

        csFile.WriteLine($"     public void Configure(EntityTypeBuilder<{Name}> builder)");
        csFile.WriteLine("     {");
        csFile.WriteLine("         //builder.Property(t => t.Code).IsRequired();");
        csFile.WriteLine("     }");

        csFile.WriteLine("    }");

        csFile.Flush();
        csFile.Close();
        csFile.Dispose();

    }

    internal void GenerateCreateCommand()
    {
        var folderName = NameSpace + $".Application\\Services\\{Name}\\Commands\\Create{Name}";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\Create" + Name + "Command.cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);
        csFile.WriteLine("        using AutoMapper;");
        csFile.WriteLine("        using IASC.Core.Application.MediatR.Interfaces;");
        csFile.WriteLine("        using IASC.Core.Repositories;");
        csFile.WriteLine($"        using {NameSpace}.Application.DTOs;");
        csFile.WriteLine($"        using {NameSpace}.Domain.Entities;");
        csFile.WriteLine($"        using {NameSpace}.Infrastructure.Persitence;");
        csFile.WriteLine("");
        csFile.WriteLine($"        namespace {NameSpace}.Application.{Name}s.Commands.Create{Name};");
        csFile.WriteLine($"");
        csFile.WriteLine($"        public record Create{Name}Command : IRequestBase<{Name}Dto>");
        csFile.WriteLine("        {");
        csFile.WriteLine("            //Other Properties");
        csFile.WriteLine("");
        csFile.WriteLine("        }");
        csFile.WriteLine("");
        csFile.WriteLine($"        public class Create{Name}CommandHandler : IRequestBaseHandler<Create{Name}Command, {Name}Dto>");
        csFile.WriteLine("        {");
        csFile.WriteLine($"            private IRepositoryBase<theDbContext, {Name}, {Name}IdType>     _{Name}Repository;");
        csFile.WriteLine($"            private readonly IMapper _mapper;");
        csFile.WriteLine($"");
        csFile.WriteLine($"");
        csFile.WriteLine($"            public Create{Name}CommandHandler(IRepositoryBase<theDbContext, {Name}, {Name}IdType> {Name}Repository, IMapper mapper)");
        csFile.WriteLine("            {");
        csFile.WriteLine($"                _{Name}Repository = {Name}Repository;");
        csFile.WriteLine($"                _mapper = mapper;");
        csFile.WriteLine("            }");
        csFile.WriteLine("");
        csFile.WriteLine($"            public async Task<{Name}Dto> Handle(Create{Name}Command request, CancellationToken cancellationToken)");
        csFile.WriteLine("            {");
        csFile.WriteLine($"                //var entity = new {Name}" + " { Code= request.Code,Title=request.Title };");
        csFile.WriteLine($"                //var result = await _{Name}Repository.InsertAsync(entity, autoSave: true);");
        csFile.WriteLine($"                //return _mapper.Map<{Name}Dto>(result);");
        csFile.WriteLine("            }");
        csFile.WriteLine("        }");

        csFile.Flush();
        csFile.Close();
        csFile.Dispose();

    }



    internal void GenerateCreateCommandValidator()
    {
        var folderName = NameSpace + $".Application\\Services\\{Name}\\Commands\\Create{Name}";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\Create" + Name + "CommandValidator.cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);

        csFile.WriteLine("using FluentValidation;");
        csFile.WriteLine("using IASC.Core.Validation;");
        csFile.WriteLine("");
        csFile.WriteLine($"namespace {NameSpace}.Application.{Name}s.Commands.Create{Name};");
        csFile.WriteLine("");
        csFile.WriteLine($"public class Create{Name}CommandValidator : BaseRequestValidator<Create{Name}Command>");
        csFile.WriteLine("{");
        csFile.WriteLine($"    public Create{Name}CommandValidator()");
        csFile.WriteLine("    {");
        csFile.WriteLine("        //RuleFor");
        csFile.WriteLine("");
        csFile.WriteLine("    }");
        csFile.WriteLine("}");



        csFile.Flush();
        csFile.Close();
        csFile.Dispose();

    }

    internal void GenerateDeleteCommand()
    {
        var folderName = NameSpace + $".Application\\Services\\{Name}\\Commands\\Delete{Name}";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\Delete" + Name + "Command.cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);

        csFile.WriteLine("using IASC.Core.Application.MediatR.Interfaces;");
        csFile.WriteLine("using IASC.Core.Repositories;");
        csFile.WriteLine($"using {NameSpace}.Domain.Entities;");
        csFile.WriteLine($"using {NameSpace}.Infrastructure.Persitence;");
        csFile.WriteLine("using MediatR;");
        csFile.WriteLine("");
        csFile.WriteLine($"namespace {NameSpace}.Application.{Name}s.Commands.Delete{Name};");
        csFile.WriteLine("");
        csFile.WriteLine($"public record Delete{Name}Command({Name}IdType Id) : IRequestBase;");
        csFile.WriteLine("");
        csFile.WriteLine("");
        csFile.WriteLine($"public class Delete{Name}CommandHandler : IRequestBaseHandler<Delete{Name}Command>");
        csFile.WriteLine("{");
        csFile.WriteLine($"    private IRepositoryBase<EvaluationCenterDbContext, {Name}, {Name}IdType> _{Name}Repository;");
        csFile.WriteLine("");
        csFile.WriteLine($"    public Delete{Name}CommandHandler(IRepositoryBase<EvaluationCenterDbContext, {Name}, {Name}IdType> {Name}Repository)");
        csFile.WriteLine("    {");
        csFile.WriteLine($"        _{Name}Repository = {Name}Repository;");
        csFile.WriteLine("    }");
        csFile.WriteLine("");
        csFile.WriteLine($"    public async Task<Unit> Handle(Delete{Name}Command request, CancellationToken cancellationToken)");
        csFile.WriteLine("    {");
        csFile.WriteLine($"        await _{Name}Repository.DeleteAsync(request.Id,autoSave:true);");
        csFile.WriteLine("");
        csFile.WriteLine("        return  Unit.Value;");
        csFile.WriteLine("    }");
        csFile.WriteLine("}");



        csFile.Flush();
        csFile.Close();
        csFile.Dispose();
    }



    internal void GenerateDeleteCommandValidator()
    {
        var folderName = NameSpace + $".Application\\Services\\{Name}\\Commands\\Delete{Name}";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\Delete" + Name + "CommandValidator.cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);

        csFile.WriteLine("using FluentValidation;");
        csFile.WriteLine("using IASC.Core.Validation;");
        csFile.WriteLine("");
        csFile.WriteLine($"namespace {NameSpace}.Application.{Name}s.Commands.Delete{Name};");
        csFile.WriteLine("");
        csFile.WriteLine($"public class Delete{Name}Validator : BaseRequestValidator<Delete{Name}Command>");
        csFile.WriteLine("{");
        csFile.WriteLine($"    public Delete{Name}CommandValidator()");
        csFile.WriteLine("    {");
        csFile.WriteLine("         RuleFor(v => v.Id)\r\n           .NotNull();");
        csFile.WriteLine("");
        csFile.WriteLine("    }");
        csFile.WriteLine("}");



        csFile.Flush();
        csFile.Close();
        csFile.Dispose();
    }



    internal void GenerateUpdateCommand()
    {
        var folderName = NameSpace + $".Application\\Services\\{Name}\\Commands\\Update{Name}";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\Update" + Name + "Command.cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);

        csFile.WriteLine("        using AutoMapper;");
        csFile.WriteLine("        using IASC.Core.Application.MediatR.Interfaces;");
        csFile.WriteLine("        using IASC.Core.Repositories;");
        csFile.WriteLine($"        using {NameSpace}.Application.DTOs;");
        csFile.WriteLine($"        using {NameSpace}.Domain.Entities;");
        csFile.WriteLine($"        using {NameSpace}.Infrastructure.Persitence;");
        csFile.WriteLine($"        using MediatR;");
        csFile.WriteLine($"");
        csFile.WriteLine($"        namespace {NameSpace}.Application.{Name}s.Commands.Update{Name};");
        csFile.WriteLine($"");
        csFile.WriteLine($"        public record Update{Name}Command : IRequestBase<{Name}Dto>");
        csFile.WriteLine("        {");
        csFile.WriteLine("            public int Id { get; init; }");
        csFile.WriteLine($"            //Other Properties");
        csFile.WriteLine($"");
        csFile.WriteLine("        }");
        csFile.WriteLine($"");
        csFile.WriteLine($"        public class Update{Name}CommandHandler : IRequestBaseHandler<Update{Name}Command, {Name}Dto>");
        csFile.WriteLine("        {");
        csFile.WriteLine($"            private IRepositoryBase<EvaluationCenterDbContext, {Name}, {Name}IdType> _{Name}Repository;");
        csFile.WriteLine($"            private readonly IMapper _mapper;");
        csFile.WriteLine($"");
        csFile.WriteLine($"            public Update{Name}CommandHandler(IRepositoryBase<EvaluationCenterDbContext, {Name}, {Name}IdType> {Name}Repository, IMapper mapper)");
        csFile.WriteLine("            {");
        csFile.WriteLine($"                _{Name}Repository = {Name}Repository;");
        csFile.WriteLine($"                _mapper = mapper;");
        csFile.WriteLine("            }");
        csFile.WriteLine("");
        csFile.WriteLine($"            public async Task<{Name}Dto> Handle(Update{Name}Command request, CancellationToken cancellationToken)");
        csFile.WriteLine("            {");
        csFile.WriteLine($"                //var entity = new {Name} " + "{Id=request.Id, Code = request.Code, Title = request.Title };");
        csFile.WriteLine($"                //var result = await _{Name}Repository.UpdateAsync(entity, autoSave: true);");
        csFile.WriteLine($"                //return _mapper.Map<{Name}Dto>(result);");
        csFile.WriteLine("            }");
        csFile.WriteLine("        }");

        csFile.Flush();
        csFile.Close();
        csFile.Dispose();
    }

    internal void GenerateUpdateCommandValidator()
    {
        var folderName = NameSpace + $".Application\\Services\\{Name}\\Commands\\Update{Name}";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\Update" + Name + "CommandValidator.cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);

        csFile.WriteLine("using FluentValidation;");
        csFile.WriteLine("using IASC.Core.Validation;");
        csFile.WriteLine("");
        csFile.WriteLine($"namespace {NameSpace}.Application.{Name}s.Commands.Update{Name};");
        csFile.WriteLine("");
        csFile.WriteLine($"public class Update{Name}CommandValidator : BaseRequestValidator<Update{Name}Command>");
        csFile.WriteLine("{");
        csFile.WriteLine($"    public Update{Name}CommandValidator()");
        csFile.WriteLine("    {");
        csFile.WriteLine("        RuleFor(v => v.Id)");
        csFile.WriteLine("           .NotEmpty();");
        csFile.WriteLine("        //Other Rules");
        csFile.WriteLine("    }");
        csFile.WriteLine("}");

        csFile.Flush();
        csFile.Close();
        csFile.Dispose();
    }


    internal void GenerateGetByIDQuery()
    {
        var folderName = NameSpace + $".Application\\Services\\{Name}\\Queries\\Get{Name}ById";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\Get" + Name + "ByIdQuery.cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);

        csFile.WriteLine("        using AutoMapper;");
        csFile.WriteLine("        using IASC.Core.Application.MediatR.Interfaces;");
        csFile.WriteLine("        using IASC.Core.Repositories;");
        csFile.WriteLine($"        using {NameSpace}.Application.DTOs;");
        csFile.WriteLine($"        using {NameSpace}.Domain.Entities;");
        csFile.WriteLine($"        using {NameSpace}.Infrastructure.Persitence;");
        csFile.WriteLine("");
        csFile.WriteLine("");
        csFile.WriteLine($"        namespace {NameSpace}.Application.{Name}s.Queries.Get{Name}sWithPagination;");
        csFile.WriteLine("");
        csFile.WriteLine($"        public record Get{Name}sByIdQuery : IRequestBase<{Name}Dto>");
        csFile.WriteLine("        {");
        csFile.WriteLine("");
        csFile.WriteLine("            public int Id { get; init; } ");
        csFile.WriteLine("");
        csFile.WriteLine("        }");
        csFile.WriteLine("");
        csFile.WriteLine($"        public class GetTodoItemByIdQueryHandler : IRequestBaseHandler<Get{Name}sByIdQuery, {Name}Dto>");
        csFile.WriteLine("        {");
        csFile.WriteLine($"            private IRepositoryBase<EvaluationCenterDbContext, {Name}, {Name}IdType> _{Name}Repository;");
        csFile.WriteLine("            private readonly IMapper _mapper;");
        csFile.WriteLine("");
        csFile.WriteLine($"            public GetTodoItemByIdQueryHandler(IRepositoryBase<EvaluationCenterDbContext, {Name}, {Name}IdType> {Name}Repository, IMapper mapper)");
        csFile.WriteLine("            {");
        csFile.WriteLine($"                _{Name}Repository = {Name}Repository;");
        csFile.WriteLine("                _mapper = mapper;");
        csFile.WriteLine("            }");
        csFile.WriteLine("");
        csFile.WriteLine($"            public async Task<{Name}Dto> Handle(Get{Name}sByIdQuery request, CancellationToken cancellationToken)");
        csFile.WriteLine("            {");
        csFile.WriteLine("");
        csFile.WriteLine($"                var entity = await _{Name}Repository.GetAsync(request.Id);");
        csFile.WriteLine($"                return _mapper.Map<{Name}, {Name}Dto>(entity);");
        csFile.WriteLine("");
        csFile.WriteLine("");
        csFile.WriteLine("");
        csFile.WriteLine("");
        csFile.WriteLine("            }");
        csFile.WriteLine("        }");


        csFile.Flush();
        csFile.Close();
        csFile.Dispose();
    }


    internal void GenerateGetByIDQueryValidator()
    {
        var folderName = NameSpace + $".Application\\Services\\{Name}\\Queries\\Get{Name}ById";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\Get" + Name + "ByIdQueryValidator.cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);


        csFile.WriteLine("using FluentValidation;");
        csFile.WriteLine("using IASC.Core.Validation;");
        csFile.WriteLine("");
        csFile.WriteLine($"namespace {NameSpace}.Application.{Name}.Queries.Get{Name}sWithPagination;");
        csFile.WriteLine("");
        csFile.WriteLine($"public class Get{Name}sByIdQueryValidator : BaseRequestValidator<Get{Name}sByIdQuery>");
        csFile.WriteLine("{");
        csFile.WriteLine($"    public Get{Name}sByIdQueryValidator()");
        csFile.WriteLine("    {");
        csFile.WriteLine("        RuleFor(x => x.Id).NotNull();");
        csFile.WriteLine("    }");
        csFile.WriteLine("}");


        csFile.Flush();
        csFile.Close();
        csFile.Dispose();
    }


    internal void GenerateGetWithPaginationQuery()
    {
        var folderName = NameSpace + $".Application\\Services\\{Name}\\Queries\\Get{Name}sWithPagination";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\Get" + Name + "sWithPaginationQuery.cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);


        csFile.WriteLine("        using AutoMapper;");
        csFile.WriteLine("        using AutoMapper.QueryableExtensions;");
        csFile.WriteLine("        using IASC.Core.Application.MediatR.Interfaces;");
        csFile.WriteLine("        using IASC.Core.Application.DTOs;");
        csFile.WriteLine("        using IASC.Core.Repositories;");
        csFile.WriteLine($"        using {NameSpace}.Application.DTOs;");
        csFile.WriteLine($"        using {NameSpace}.Domain.Entities;");
        csFile.WriteLine($"        using {NameSpace}.Infrastructure.Persitence;");
        csFile.WriteLine("        using MediatR;");
        csFile.WriteLine("");
        csFile.WriteLine($"        namespace {NameSpace}.Application.{Name}s.Queries.Get{Name}sWithPagination;");
        csFile.WriteLine("");
        csFile.WriteLine($"        public record Get{Name}sWithPaginationQuery : IRequestBase<PaginatedList<{Name}BriefDto>>");
        csFile.WriteLine("        {");
        csFile.WriteLine("");
        csFile.WriteLine("            public int PageNumber { get; init; } = 1;");
        csFile.WriteLine("            public int PageSize { get; init; } = 10;");
        csFile.WriteLine("            //Other Fields");
        csFile.WriteLine("        }");
        csFile.WriteLine("");
        csFile.WriteLine($"        public class Get{Name}sWithPaginationQueryHandler : IRequestBaseHandler<Get{Name}sWithPaginationQuery, PaginatedList<{Name}BriefDto>>");
        csFile.WriteLine("        {");
        csFile.WriteLine($"            private IRepositoryBase<EvaluationCenterDbContext, {Name}, {Name}IdType> _{Name}Repository;");
        csFile.WriteLine($"            private readonly IMapper _mapper;");
        csFile.WriteLine("");
        csFile.WriteLine($"            public Get{Name}sWithPaginationQueryHandler(IRepositoryBase<EvaluationCenterDbContext, {Name}, {Name}IdType> {Name}Repository, IMapper mapper)");
        csFile.WriteLine("            {");
        csFile.WriteLine($"                _{Name}Repository = {Name}Repository;");
        csFile.WriteLine("                _mapper = mapper;");
        csFile.WriteLine("            }");
        csFile.WriteLine("");
        csFile.WriteLine($"            public async Task<PaginatedList<{Name}BriefDto>> Handle(Get{Name}sWithPaginationQuery request, CancellationToken cancellationToken)");
        csFile.WriteLine("            {");
        csFile.WriteLine("");
        csFile.WriteLine($"                //var entities = await _{Name}Repository.GetPagedListAsync(request.PageNumber-1, request.PageSize);");
        csFile.WriteLine($"                //var count = await _{Name}Repository.GetCountAsync();");
        csFile.WriteLine($"                //List<{Name}BriefDto> result =_mapper.Map<List<{Name}>, List<{Name}BriefDto>>(entities);");
        csFile.WriteLine($"                //return new PaginatedList<{Name}BriefDto>(result, count, request.PageNumber, request.PageSize);");
        csFile.WriteLine("");
        csFile.WriteLine("");
        csFile.WriteLine("");
        csFile.WriteLine("            }");
        csFile.WriteLine("        }");


        csFile.Flush();
        csFile.Close();
        csFile.Dispose();
    }


    internal void GenerateGetWithPaginationQueryValidator()
    {
        var folderName = NameSpace + $".Application\\Services\\{Name}\\Queries\\Get{Name}sWithPagination";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\Get" + Name + "sWithPaginationQueryValidator.cs";
        if (File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);

        csFile.WriteLine("        using FluentValidation;");
        csFile.WriteLine("        using IASC.Core.Validation;");
        csFile.WriteLine("");
        csFile.WriteLine($"        namespace {NameSpace}.Application.{Name}s.Queries.Get{Name}sWithPagination;");
        csFile.WriteLine("");
        csFile.WriteLine($"        public class Get{Name}sWithPaginationQueryValidator : BaseRequestValidator<Get{Name}sWithPaginationQuery>");
        csFile.WriteLine("        {");
        csFile.WriteLine($"            public Get{Name}sWithPaginationQueryValidator()");
        csFile.WriteLine("            {");
        csFile.WriteLine("                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);");
        csFile.WriteLine("                RuleFor(x => x.PageSize).GreaterThan(0);");
        csFile.WriteLine("            }");
        csFile.WriteLine("        }");



        csFile.Flush();
        csFile.Close();
        csFile.Dispose();
    }


}
