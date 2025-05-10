using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

class Program
{
  public class FaturamentoDia
  {
    public int dia { get; set; }
    public double valor { get; set; }
  }

  static void Main()
  {
    try
    {
      string json = File.ReadAllText("dados.json");
      List<FaturamentoDia> dados = JsonSerializer.Deserialize<List<FaturamentoDia>>(json);

      var diasComFaturamento = dados.Where(d => d.valor > 0).ToList();

      double menorValor = diasComFaturamento.Min(d => d.valor);
      double maiorValor = diasComFaturamento.Max(d => d.valor);
      double mediaMensal = diasComFaturamento.Average(d => d.valor);

      int diasAcimaDaMedia = diasComFaturamento.Count(d => d.valor > mediaMensal);

      Console.WriteLine($"Menor faturamento do mês: R$ {menorValor:F2}");
      Console.WriteLine($"Maior faturamento do mês: R$ {maiorValor:F2}");
      Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Erro ao processar os dados: {ex.Message}");
    }
  }
}
