 Console.WriteLine("Média Aritmética de 3 números\n");

Console.WriteLine("Digite o primeiro número: ");
double numero1 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Digite o primeiro número: ");
double numero2 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Digite o primeiro número: ");
double numero3 = Convert.ToDouble (Console.ReadLine());

double media = (numero1 + numero2 + numero3) / 3;

Console.WriteLine($"Média: {media:N1}");