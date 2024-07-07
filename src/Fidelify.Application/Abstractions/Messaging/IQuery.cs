using Fidelify.Domain.Abstractions;
using MediatR;

namespace Fidelify.Application.Abstractions.Messaging;
public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{

}
