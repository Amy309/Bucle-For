// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int Vinicial, Vfinal;
Console.WriteLine("Ingrese primer valor");
Vinicial = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese segundo valor");
Vfinal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Los numeros pares entre estos valores {Vinicial} - {Vfinal}  son:");

for (int i = Vinicial; i <= Vfinal; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
