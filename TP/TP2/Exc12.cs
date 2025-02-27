class Exc12
{
     public static void Executar(){
        Random gerador = new Random();
        int numeroSecreto = gerador.Next(1, 101);

        Console.WriteLine("---Jogo de adivinhação---\nDigite um numero e tente adivinhar o numero secreto 1 a 100.");

        string input;

        do
        {
           Console.Write("Numero ou para sair digite '?': ");
           input = Console.ReadLine();
           
           if (int.TryParse(input, out int inputConvertido)){
            if(inputConvertido == numeroSecreto){
                Console.WriteLine($"Parabéns você acertou o número secreto era {numeroSecreto}");
                break;
            } else if (inputConvertido > numeroSecreto) {
                Console.WriteLine($"O número secreto é MENOR do que o digitado.Tente novamente");
            } else {
                Console.WriteLine($"O número secreto é MAIOR do que o digitado.Tente novamente");
            } 
           } 
        } while (input != "?");
    }
}