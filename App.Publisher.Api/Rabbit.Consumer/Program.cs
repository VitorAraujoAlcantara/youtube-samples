using App.Models.Entities;
using Confluent.Kafka;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;


CancellationTokenSource cts = new CancellationTokenSource();
Console.CancelKeyPress += (_, e) =>
{
    e.Cancel = true; // prevent the process from terminating.
    cts.Cancel();
};

var config = new ConsumerConfig
{
    BootstrapServers = "localhost:9092",
    GroupId = $"queue_kafka-group-0",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

using (var consumer = new ConsumerBuilder<string, string>(config).Build())
{
    consumer.Subscribe("queue_kafka");
    while (!cts.IsCancellationRequested)
    {
        try
        {
            var cr = consumer.Consume(cts.Token);
            var json = cr.Message.Value;
            AppMensagem mensagem = JsonSerializer.Deserialize<AppMensagem>(json);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Titulo: {mensagem.Titulo}; Texto={mensagem.Texto}; Id={mensagem.Id}");
        }
        catch (OperationCanceledException oce)
        {
            continue;
        }
    }
}


