using MassTransit;
using SharedContracts;

namespace ConsumerConsoleApp2
{
    public sealed class MessageSentEventConsumer : IConsumer<MessageSentEvent>
    {
        public Task Consume(ConsumeContext<MessageSentEvent> context)
        {
            Console.WriteLine($"Consumed Message: {context.Message.Message}");
            return Task.CompletedTask;
        }
    }
}
