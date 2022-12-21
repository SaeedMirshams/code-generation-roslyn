using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Posts.Commands.UpdatePost;

public class UpdatePostCommandValidator : BaseRequestValidator<UpdatePostCommand>
{
    public UpdatePostCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
