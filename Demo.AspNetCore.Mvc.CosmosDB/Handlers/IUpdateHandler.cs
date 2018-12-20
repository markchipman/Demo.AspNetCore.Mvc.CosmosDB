﻿using MediatR;
using Demo.AspNetCore.Mvc.CosmosDB.Requests;

namespace Demo.AspNetCore.Mvc.CosmosDB.Handlers
{
    public interface IUpdateHandler<T> : IRequestHandler<UpdateRequest<T>, T>
    { }
}
