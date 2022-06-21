using App.Models.Entities;
using App.Repositories.Interfaces;
using Confluent.Kafka;
using System.Text.Json;

namespace App.Repositories
{
    public class KafkaMensagemRepository : IAppMensagemRepository
    {
        public void SendMensagem(AppMensagem mensagem)
        {
            var config = new ProducerConfig {
                BootstrapServers = "localhost:9092" 
            };
            using (var producer = new ProducerBuilder<string, string>(config).Build())
            {
                string json = JsonSerializer.Serialize(mensagem); 
                producer.Produce("queue_kafka",
                                        new Message<string, string>
                                        {
                                            Key =  Guid.NewGuid().ToString(),
                                            Value = json
                                        });
            }
        }
    }
}
