Console.Write("Digite um número: ");

int variavelQueSalvaUmNumero = int.Parse(Console.ReadLine()!);

if (variavelQueSalvaUmNumero % 2 == 0)
{
    Console.WriteLine($"Número {variavelQueSalvaUmNumero} é par");
}
else
{
    Console.WriteLine($"Número {variavelQueSalvaUmNumero} é ímpar");
}