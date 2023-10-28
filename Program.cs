int n1;
int n2;

Console.Write("Digite um número: ");
int.TryParse(Console.ReadLine()!, out n1);
Console.WriteLine();

Console.Write("Avaliar se ele é múltiplo de: ");
int.TryParse(Console.ReadLine()!, out n2);
Console.WriteLine();

if( n1 % n2 == 0)
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor  = ConsoleColor.Green;
    Console.WriteLine($"{n1} é múltiplo de {n2} ");
    Console.ResetColor();
}

else
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine($"{n1} não é múltiplo de {n2} ");
    Console.ResetColor();
}

