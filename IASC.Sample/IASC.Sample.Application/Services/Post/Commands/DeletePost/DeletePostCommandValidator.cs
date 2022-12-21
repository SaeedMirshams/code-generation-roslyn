using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Posts.Commands.DeletePost;

public class DeletePostCommandValidator : BaseRequestValidator<DeletePostCommand>
{
    public DeletePostCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
