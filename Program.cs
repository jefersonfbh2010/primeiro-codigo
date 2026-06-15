Console.WriteLine("Informe o valor total da compra:");

double valorCompra = double.Parse(Console.ReadLine());

double desconto;
double valorFinal;

if (valorCompra >= 200)
{
    desconto = valorCompra * 0.10;
}
else
{
    desconto = 0;
}

valorFinal = valorCompra - desconto;

Console.WriteLine("Valor original: R$ " + valorCompra);
Console.WriteLine("Desconto aplicado: R$ " + desconto);
Console.WriteLine("Valor final: R$ " + valorFinal);