using System.Text.Json;
using Repositories;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

VendaRepository repository = new VendaRepository();

var vendas = repository.GetByCpf("111.111.111-11");


var jsonVendas = JsonSerializer.Serialize(vendas, new JsonSerializerOptions{
    WriteIndented = true
});

Console.WriteLine(jsonVendas);

Console.ReadLine();
