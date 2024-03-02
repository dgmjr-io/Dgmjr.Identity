namespace Dgmjr.Graph.Identity;

using global::Microsoft.Extensions.Options;
using global::Microsoft.Graph;
using global::Microsoft.Identity.Web;
using Application = global::Microsoft.Graph.Application;

public abstract class GraphService(
    GraphServiceClient graphServiceClient,
    IOptions<MicrosoftIdentityOptions> options
) : IDisposable
{
    protected GraphServiceClient GraphServiceClient => graphServiceClient;
private readonly MicrosoftIdentityOptions _options = options?.Value;
protected string ClientId =>
    _options?.ClientId ?? throw new InvalidOperationException("ClientId is required");
private bool _disposedValue;

protected virtual async Task<Application> GetApplication() =>
    (
        await GraphServiceClient.Applications
            .Request()
            .Filter($"appId eq '{ClientId}'")
            .GetAsync()
    ).FirstOrDefault();

protected virtual void Dispose(bool disposing)
{
    if (!_disposedValue)
    {
        if (disposing) { }

        _disposedValue = true;
    }
}

public void Dispose()
{
    // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    Dispose(disposing: true);
    GC.SuppressFinalize(this);
}
}
