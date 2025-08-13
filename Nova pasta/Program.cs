using Nova_pasta.Models;
using System;
using Newtonsoft.Json;



//Deserialization
string readText = File.ReadAllText("Arquivos/vendas.json");
List<Venda> vendas = JsonConvert.DeserializeObject<List<Venda>>(readText);

foreach (var venda in vendas) {
    Console.WriteLine($"Id: {venda.Id}, Product: {venda.Product}, Price: {venda.Price}, SaleDate: {venda.SaleDate}");
}


// //Serialization
// DateTime dataAtual = DateTime.Now;
// List<Venda> vendas = new List<Venda>();

// Venda v1 = new Venda(1, "Laptop", 1500.00m, dataAtual);
// Venda v2 = new Venda(2, "Smartphone", 800.00m, dataAtual);

// vendas.Add(v1);
// vendas.Add(v2);

// string jsonV1 = JsonConvert.SerializeObject(vendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", jsonV1);

// Console.WriteLine($"Serialized Venda v1:  {jsonV1}");