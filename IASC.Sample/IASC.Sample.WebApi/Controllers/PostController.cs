using IASC.Sample.Application.Posts.Commands.CreatePost;
using IASC.Sample.Application.Posts.Commands.DeletePost;
using IASC.Sample.Application.Posts.Commands.UpdatePost;
using IASC.Sample.Application.Posts.Queries.GetPostsWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class PostsController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public PostsController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<PostBriefDto>>> GetPostsWithPagination([FromQuery] GetPostsWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<PostBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<PostDto>> Create(CreatePostCommand command)
    {
        return new ApiSuccessResult<PostDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<PostDto>> Update(int id, UpdatePostCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<PostDto>(null, null);
        }

        return new ApiSuccessResult<PostDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeletePostCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
