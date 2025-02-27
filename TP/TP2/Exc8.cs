class Exc8
{
    public static void Executar(){
        Console.Write("Digite uma nota de 0 a 10: ");
        int nota = int.Parse(Console.ReadLine()); 

        if (nota <= 4){
            Console.WriteLine("Insuficiente");
        } else if (nota > 4 && nota <= 6) {
            Console.WriteLine("Regular");
        } else if (nota > 6 && nota <= 8) {
            Console.WriteLine("Bom");
        } else if (nota > 8 && nota <= 10) {
            Console.WriteLine("Excelente");
        } else {
            Console.WriteLine("Nota com valor inválido.");
        }
    }
}