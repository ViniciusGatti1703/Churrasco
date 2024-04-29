int qtdeConvidados;
decimal valorKgCarne = 35m;
decimal valorLataCerveja = 2.49m;
decimal consumoCarnePorPessoa = 0.500m;
decimal consumoCervejaPorPessoa = 6;
decimal qtdeTotalCarne;
decimal qtdeTotalCerveja;
decimal valorTotalCarne;
decimal valorTotalCerveja;
decimal valorTotal;
decimal desconto = 0;

Console.Write("Informe o número de convidados: ");
qtdeConvidados = Convert.ToInt32(Console.ReadLine());

qtdeTotalCarne = qtdeConvidados * consumoCarnePorPessoa;
valorTotalCarne = qtdeTotalCarne * valorKgCarne;
qtdeTotalCerveja = qtdeConvidados * consumoCervejaPorPessoa;
valorTotalCerveja = qtdeTotalCerveja * valorLataCerveja;
valorTotal = valorTotalCarne + valorTotalCerveja;

if (valorTotal > 100 && valorTotal <= 300)
{
    desconto = valorTotal * 0.05m;
}
else if (valorTotal > 300)
{
    desconto = valorTotal * 0.10m;
}
Console.Clear();
Console.WriteLine("Número de Convidados: " + qtdeConvidados);
Console.WriteLine("Qtde de Carne: " + qtdeTotalCarne);
Console.WriteLine("Valor de Carne: " + valorTotalCarne);
Console.WriteLine("Qtde de Cerveja: " + qtdeTotalCerveja);
Console.WriteLine("Valor de Cerveja: " + valorTotalCerveja);
Console.WriteLine("Desconto: " + desconto.ToString("F2"));
Console.WriteLine("Valor Total: " + (valorTotal - desconto));