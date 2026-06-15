Console.WriteLine("Informe o valor total da compra:");

double valorCompra = double.Parse(Console.ReadLine()!);

double desconto = 0;

if (valorCompra >= 200)
{
    desconto = valorCompra * 0.10;
}

double valorFinal = valorCompra - desconto;

Console.WriteLine("Valor original: R$ " + valorCompra);
Console.WriteLine("Desconto aplicado: R$ " + desconto);
Console.WriteLine("Valor final: R$ " + valorFinal);