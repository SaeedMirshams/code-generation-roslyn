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
        if (!Forced && File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);
        csFile.WriteLine("using IASC.Core.Entities;");
        if (IsUsingEnums)
        {
            csFile.WriteLine($"using {NameSpace}.Domain.Enums;");

        }
        csFile.WriteLine("namespace " + NameSpace + ".Domain.Entities");
        csFile.WriteLine("{");
        csFile.WriteLine("    public class " + Name + " : " + BaseType + "<" + GenericType + ">");
        csFile.WriteLine("    {");
        foreach (var field in Fields)
        {
            csFile.WriteLine($"        {field.AccessModifier} {field.FieldType} {field.Name} " + "{ get; set; }");

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
        if (!Forced && File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);
        csFile.WriteLine("");

        csFile.WriteLine("using IASC.Core.Application.DTOs;");
        csFile.WriteLine("using IASC.Core.Application.Mappings;");
        if (IsUsingEnums)
        {
            csFile.WriteLine($"using {NameSpace}.Domain.Enums;");
        }
        csFile.WriteLine($"using {NameSpace}.Domain.Entities;");

        csFile.WriteLine("namespace " + NameSpace + ".Application.DTOs;\r\n");

        csFile.WriteLine($"public class {Name}BriefDto : EntityDto<{GenericType}>,IMapFrom<{Name}>");
        csFile.WriteLine("    {");

        foreach (var field in ExplicitFields)
        {
            csFile.WriteLine($"        {field.AccessModifier} {field.FieldType} {field.Name} " + "{ get; set; }");

        }

        foreach (var field in RelationFields)
        {
            if (field.IsEnumRelated)
                csFile.WriteLine($"        {field.AccessModifier} {field.FieldType} {field.Name} " + "{ get; set; }");

        }



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
        if (!Forced && File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);
        csFile.WriteLine("");

        csFile.WriteLine("using IASC.Core.Application.DTOs;");
        csFile.WriteLine("using IASC.Core.Application.Mappings;");
        if (IsUsingEnums)
        {
            csFile.WriteLine($"using {NameSpace}.Domain.Enums;");
        }
        csFile.WriteLine($"using {NameSpace}.Domain.Entities;");

        csFile.WriteLine("namespace " + NameSpace + ".Application.DTOs\r\n");
        csFile.WriteLine("{");

        csFile.WriteLine($"public class {Name}Dto : EntityDto<{GenericType}>,IMapFrom<{Name}>");
        csFile.WriteLine("    {");

        foreach (var field in ExplicitFields)
        {
            csFile.WriteLine($"        {field.AccessModifier} {field.FieldType} {field.Name} " + "{ get; set; }");

        }

        foreach (var field in RelationFields)
        {
            if (field.IsEnumRelated)
                csFile.WriteLine($"        {field.AccessModifier} {field.FieldType} {field.Name} " + "{ get; set; }");

        }


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
        if (!Forced && File.Exists(fileName))
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
        if (!Forced && File.Exists(fileName))
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
        csFile.WriteLine($"        using {NameSpace}.Infrastructure.Persistence;");
        csFile.WriteLine("");
        csFile.WriteLine($"        namespace {NameSpace}.Application.{Name}s.Commands.Create{Name};");
        csFile.WriteLine($"");
        csFile.WriteLine($"        public record Create{Name}Command : IRequestBase<{Name}Dto>");
        csFile.WriteLine("        {");
        csFile.WriteLine("            //Other Properties");
        foreach (var field in ExplicitFields)
        {
            csFile.WriteLine($"        {field.AccessModifier} {field.FieldType} {field.Name} " + "{ get; set; }");

        }

        csFile.WriteLine("");
        csFile.WriteLine("        }");
        csFile.WriteLine("");
        csFile.WriteLine($"        public class Create{Name}CommandHandler : IRequestBaseHandler<Create{Name}Command, {Name}Dto>");
        csFile.WriteLine("        {");
        csFile.WriteLine($"            private IRepositoryBase<AppDbContext, {Name}, {GenericType}>     _{Name}Repository;");
        csFile.WriteLine($"            private readonly IMapper _mapper;");
        csFile.WriteLine($"");
        csFile.WriteLine($"");
        csFile.WriteLine($"            public Create{Name}CommandHandler(IRepositoryBase<AppDbContext, {Name}, {GenericType}> {Name}Repository, IMapper mapper)");
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
        csFile.WriteLine($"                throw new NotImplementedException();");
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
        if (!Forced && File.Exists(fileName))
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
        if (!Forced && File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);

        csFile.WriteLine("using IASC.Core.Application.MediatR.Interfaces;");
        csFile.WriteLine("using IASC.Core.Repositories;");
        csFile.WriteLine($"using {NameSpace}.Domain.Entities;");
        csFile.WriteLine($"using {NameSpace}.Infrastructure.Persistence;");
        csFile.WriteLine("using MediatR;");
        csFile.WriteLine("");
        csFile.WriteLine($"namespace {NameSpace}.Application.{Name}s.Commands.Delete{Name};");
        csFile.WriteLine("");
        csFile.WriteLine($"public record Delete{Name}Command({GenericType} Id) : IRequestBase;");
        csFile.WriteLine("");
        csFile.WriteLine("");
        csFile.WriteLine($"public class Delete{Name}CommandHandler : IRequestBaseHandler<Delete{Name}Command>");
        csFile.WriteLine("{");
        csFile.WriteLine($"    private IRepositoryBase<AppDbContext, {Name}, {GenericType}> _{Name}Repository;");
        csFile.WriteLine("");
        csFile.WriteLine($"    public Delete{Name}CommandHandler(IRepositoryBase<AppDbContext, {Name}, {GenericType}> {Name}Repository)");
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
        if (!Forced && File.Exists(fileName))
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
        csFile.WriteLine($"public class Delete{Name}CommandValidator : BaseRequestValidator<Delete{Name}Command>");
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
        if (!Forced && File.Exists(fileName))
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
        csFile.WriteLine($"        using {NameSpace}.Infrastructure.Persistence;");
        csFile.WriteLine($"        using MediatR;");
        csFile.WriteLine($"");
        csFile.WriteLine($"        namespace {NameSpace}.Application.{Name}s.Commands.Update{Name};");
        csFile.WriteLine($"");
        csFile.WriteLine($"        public record Update{Name}Command : IRequestBase<{Name}Dto>");
        csFile.WriteLine("        {");
        csFile.WriteLine("            public int Id { get; init; }");
        csFile.WriteLine($"            //Other Properties");
        foreach (var field in ExplicitFields)
        {
            csFile.WriteLine($"        {field.AccessModifier} {field.FieldType} {field.Name} " + "{ get; set; }");

        }
        csFile.WriteLine($"");
        csFile.WriteLine("        }");
        csFile.WriteLine($"");
        csFile.WriteLine($"        public class Update{Name}CommandHandler : IRequestBaseHandler<Update{Name}Command, {Name}Dto>");
        csFile.WriteLine("        {");
        csFile.WriteLine($"            private IRepositoryBase<AppDbContext, {Name}, {GenericType}> _{Name}Repository;");
        csFile.WriteLine($"            private readonly IMapper _mapper;");
        csFile.WriteLine($"");
        csFile.WriteLine($"            public Update{Name}CommandHandler(IRepositoryBase<AppDbContext, {Name},  {GenericType} > {Name}Repository, IMapper mapper)");
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
        csFile.WriteLine($"                throw new NotImplementedException();");
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
        if (!Forced && File.Exists(fileName))
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
        if (!Forced && File.Exists(fileName))
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
        csFile.WriteLine($"        using {NameSpace}.Infrastructure.Persistence;");
        csFile.WriteLine("");
        csFile.WriteLine("");
        csFile.WriteLine($"        namespace {NameSpace}.Application.{Name}s.Queries.Get{Name}sWithPagination;");
        csFile.WriteLine("");
        csFile.WriteLine($"        public record Get{Name}sByIdQuery : IRequestBase<{Name}Dto>");
        csFile.WriteLine("        {");
        csFile.WriteLine("");
        csFile.WriteLine("            public " + GenericType + " Id { get; init; } ");
        csFile.WriteLine("");
        csFile.WriteLine("        }");
        csFile.WriteLine("");
        csFile.WriteLine($"        public class Get{Name}ByIdQueryHandler : IRequestBaseHandler<Get{Name}sByIdQuery, {Name}Dto>");
        csFile.WriteLine("        {");
        csFile.WriteLine($"            private IRepositoryBase<AppDbContext, {Name},  {GenericType} > _{Name}Repository;");
        csFile.WriteLine("            private readonly IMapper _mapper;");
        csFile.WriteLine("");
        csFile.WriteLine($"            public Get{Name}ByIdQueryHandler(IRepositoryBase<AppDbContext, {Name}, {GenericType}> {Name}Repository, IMapper mapper)");
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
        if (!Forced && File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);


        csFile.WriteLine("using FluentValidation;");
        csFile.WriteLine("using IASC.Core.Validation;");
        csFile.WriteLine("");
        csFile.WriteLine($"namespace {NameSpace}.Application.{Name}s.Queries.Get{Name}sWithPagination;");
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
        if (!Forced && File.Exists(fileName))
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
        csFile.WriteLine($"        using {NameSpace}.Infrastructure.Persistence;");
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
        csFile.WriteLine($"            private IRepositoryBase<AppDbContext, {Name},  {GenericType} > _{Name}Repository;");
        csFile.WriteLine($"            private readonly IMapper _mapper;");
        csFile.WriteLine("");
        csFile.WriteLine($"            public Get{Name}sWithPaginationQueryHandler(IRepositoryBase<AppDbContext, {Name},  {GenericType} > {Name}Repository, IMapper mapper)");
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
        csFile.WriteLine($"                throw new NotImplementedException();"); csFile.WriteLine("");
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
        if (!Forced && File.Exists(fileName))
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

    internal void GenerateController()
    {
        var folderName = NameSpace + $".WebApi\\Controllers";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var fileName = folderName + "\\" + Name + "Controller.cs";
        if (!Forced && File.Exists(fileName))
        {
            Console.WriteLine($"{fileName} Ignored.");
            return;
        }
        StreamWriter csFile = new StreamWriter(fileName);
        csFile.WriteLine($"using {NameSpace}.Application.{Name}s.Commands.Create{Name};");
        csFile.WriteLine($"using {NameSpace}.Application.{Name}s.Commands.Delete{Name};");
        csFile.WriteLine($"using {NameSpace}.Application.{Name}s.Commands.Update{Name};");
        csFile.WriteLine($"using {NameSpace}.Application.{Name}s.Queries.Get{Name}sWithPagination;");
        csFile.WriteLine("using IASC.Core.Application.DTOs;");
        csFile.WriteLine("using IASC.Core.WebApi;");
        csFile.WriteLine("using MediatR;");
        csFile.WriteLine("using Microsoft.AspNetCore.Authorization;");
        csFile.WriteLine("using Microsoft.AspNetCore.Mvc;");
        csFile.WriteLine($"using {NameSpace}.Application.DTOs;");
        csFile.WriteLine("using System.Net;");
        //csFile.WriteLine("using IdentityModel.Client;");
        csFile.WriteLine("");
        csFile.WriteLine($"namespace {NameSpace}.WebUI.Controllers;");
        csFile.WriteLine("");
        csFile.WriteLine("");
        csFile.WriteLine($"public class {Name}sController : IASCApiControllerBase");
        csFile.WriteLine("{");
        csFile.WriteLine("    private readonly IMediator _mediator;");
        csFile.WriteLine($"    public {Name}sController(IMediator mediator) => _mediator = mediator;");
        csFile.WriteLine("    ");
        csFile.WriteLine("");
        csFile.WriteLine("    [HttpGet]");
        csFile.WriteLine($"    public async Task<ApiResult<PaginatedList<{Name}BriefDto>>> Get{Name}sWithPagination([FromQuery] Get{Name}sWithPaginationQuery query)");
        csFile.WriteLine("    {");
        csFile.WriteLine($"       return new ApiSuccessResult<PaginatedList<{Name}BriefDto>>(null, await _mediator.Send(query));");
        csFile.WriteLine("    }");
        csFile.WriteLine("");
        csFile.WriteLine("    [HttpPost]");
        csFile.WriteLine($"    public async Task<ApiResult<{Name}Dto>> Create(Create{Name}Command command)");
        csFile.WriteLine("    {");
        csFile.WriteLine($"        return new ApiSuccessResult<{Name}Dto>( null, await _mediator.Send(command));");
        csFile.WriteLine("    }");
        csFile.WriteLine("");
        csFile.WriteLine("    [HttpPut(\"{id}\")]");
        csFile.WriteLine($"    public async Task<ApiResult<{Name}Dto>> Update(int id, Update{Name}Command command)");
        csFile.WriteLine("    {");
        csFile.WriteLine("        if (id != command.Id)");
        csFile.WriteLine("        {");
        csFile.WriteLine($"            return new ApiErrorResult<{Name}Dto>(null, null);");
        csFile.WriteLine("        }");
        csFile.WriteLine("");
        csFile.WriteLine($"        return new ApiSuccessResult<{Name}Dto>( null, await _mediator.Send(command));");
        csFile.WriteLine("");
        csFile.WriteLine("");
        csFile.WriteLine("        ");
        csFile.WriteLine("    }");
        csFile.WriteLine("");
        csFile.WriteLine("    [HttpDelete(\"{id}\")]");
        csFile.WriteLine("    public async Task<ApiResult<object>> Delete(int id)");
        csFile.WriteLine("    {");
        csFile.WriteLine($"        await _mediator.Send(new Delete{Name}Command(id));");
        csFile.WriteLine("        return new ApiSuccessResult<object>( null, null);");
        csFile.WriteLine("");
        csFile.WriteLine("");
        csFile.WriteLine("        ");
        csFile.WriteLine("    }");
        csFile.WriteLine("}");


        csFile.Flush();
        csFile.Close();
        csFile.Dispose();
    }
}
