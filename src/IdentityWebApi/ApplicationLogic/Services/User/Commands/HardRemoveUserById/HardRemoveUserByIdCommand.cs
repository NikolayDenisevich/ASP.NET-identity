using IdentityWebApi.ApplicationLogic.Services.Common;
using IdentityWebApi.Core.Results;

using System;

using MediatR;

namespace IdentityWebApi.ApplicationLogic.Services.User.Commands.HardRemoveUserById;

/// <summary>
/// Hard remove user by id CQRS command.
/// </summary>
public record HardRemoveUserByIdCommand : IBaseId, IRequest<ServiceResult>
{
    /// <summary>
    /// Gets user id.
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="HardRemoveUserByIdCommand"/> class.
    /// </summary>
    /// <param name="id">User id.</param>
    public HardRemoveUserByIdCommand(Guid id)
    {
        this.Id = id;
    }
}
