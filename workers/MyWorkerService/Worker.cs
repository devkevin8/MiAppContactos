using System.Threading.Channels;

namespace MyWorkerService;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly Channel<int> _channel;

    public Worker(ILogger<Worker> logger, Channel<int> channel)
    {
        _logger = logger;
        _channel = channel;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (await _channel.Reader.WaitToReadAsync(stoppingToken))
            {
                while (_channel.Reader.TryRead(out var contactoId))
                {
                    _logger.LogInformation("Processing Contacto ID: {ContactoId}", contactoId);
                    // Simulating background work
                    await Task.Delay(1000, stoppingToken); // Replace with actual work
                }
            }
        }
    }
}
