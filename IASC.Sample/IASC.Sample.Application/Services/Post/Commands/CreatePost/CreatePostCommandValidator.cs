using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Posts.Commands.CreatePost;

public class CreatePostCommandValidator : BaseRequestValidator<CreatePostCommand>
{
    public CreatePostCommandValidator()
    {
        //RuleFor

    }
}
