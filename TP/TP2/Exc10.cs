class Exc10
{
    public static void Executar(){
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine()); 

        string contagemRegressiva = $"{numero}";

        for (int i = numero - 1; i >= 0; i--){
            contagemRegressiva += $", {i}";
        }

        Console.WriteLine(contagemRegressiva);
    }
}