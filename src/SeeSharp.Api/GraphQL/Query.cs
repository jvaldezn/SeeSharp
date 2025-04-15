﻿using AutoMapper;
using MediatR;
using SeeSharp.Application.Common.Interfaces;
using SeeSharp.Application.Features.BlogPosts.Queries;
using SeeSharp.Infrastructure.DbContexts;

namespace SeeSharp.Api.GraphQL;

public class Query
{

    public Query()
    {
    }

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public async Task<List<BlogPostDto>> GetBlogPosts([Service] IMediator mediatr)
    {
        return await mediatr.Send(new GetBlogPostsQuery());
    }

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public async Task<BlogPostDto> GetBlogPostById([Service] IMediator mediatr, string id)
    {
        return await mediatr.Send(new GetBlogPostByIdQuery(Guid.Parse(id)));
    }
}
