using ConsumerConsoleApp2;
using MassTransit;

var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
{
    cfg.Host("amqp://rabbitmq:5672", h =>
    {
        h.Username("guest");
        h.Password("guest");
    });

    cfg.ReceiveEndpoint("MassTransitTestQueue", e =>
    {
        e.Consumer<MessageSentEventConsumer>();
    });




});
await busControl.StartAsync();

try
{
    Console.WriteLine("Starting to consume messages...");

    await Task.Run(Console.ReadLine);

}
finally
{
    await busControl.StopAsync();
}