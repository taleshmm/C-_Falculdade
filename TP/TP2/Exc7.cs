class Exc7
{
    public static void Executar(){
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine()); 

        if (numero % 2 == 0) {
            Console.WriteLine("Este número é PAR.");
        } else {
             Console.WriteLine("Este número é ÍMPAR.");
        }
    }
}
