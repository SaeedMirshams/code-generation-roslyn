using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.Exams.Commands.DeleteExam;

public record DeleteExamCommand(int Id) : IRequestBase;


public class DeleteExamCommandHandler : IRequestBaseHandler<DeleteExamCommand>
{
    private IRepositoryBase<AppDbContext, Exam, int> _ExamRepository;

    public DeleteExamCommandHandler(IRepositoryBase<AppDbContext, Exam, int> ExamRepository)
    {
        _ExamRepository = ExamRepository;
    }

    public async Task<Unit> Handle(DeleteExamCommand request, CancellationToken cancellationToken)
    {
        await _ExamRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
