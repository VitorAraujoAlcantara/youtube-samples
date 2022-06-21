using App.Models.Entities;
using App.Repositories.Interfaces;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace App.Repositories
{
    public class RabbitMensagemRepository : IAppMensagemRepository
    {
        public void SendMensagem(AppMensagem mensagem)
        {
            var factory = new ConnectionFactory() { 
                HostName = "localhost" ,
                UserName = "admin",
                Password = "123456"
            };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "rabbitMensagesQueue",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                string json =  JsonSerializer.Serialize(mensagem);
                var body = Encoding.UTF8.GetBytes(json);

                channel.BasicPublish(exchange: "",
                                     routingKey: "rabbitMensagesQueue",
                                     basicProperties: null,
                                     body: body);                
            }
        }
    }
}
