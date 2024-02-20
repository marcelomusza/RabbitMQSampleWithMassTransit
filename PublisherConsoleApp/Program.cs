using MassTransit;
using SharedContracts;

var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
{
    cfg.Host("amqp://rabbitmq:5672", h =>
    {
        h.Username("guest");
        h.Password("guest");
    });

});
await busControl.StartAsync();

try
{
    Console.WriteLine("Starting to send messages...");

    for (int i = 0; i < 60; i++)
    {
        Console.WriteLine($"Sending Message {i}");
        await busControl.Publish<MessageSentEvent>(new
        {
            Message = $"This is message number {i}"
        });
        Thread.Sleep(1000);
    }

}
finally
{
    await busControl.StopAsync();
}