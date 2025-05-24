namespace Mediator.Implementation;

public sealed record Request(Guid id);

public interface IRequestHandler<in TRequest, TResponse>
{
    Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
}