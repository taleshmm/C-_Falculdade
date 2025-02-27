class Exc11
{
     public static void Executar(){
        Console.Write("Digite um número inteiro para ver sua tabuada até 10:\n ");
        int numero = int.Parse(Console.ReadLine());  

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} * {i} = {numero * i}");
        }
    }
}