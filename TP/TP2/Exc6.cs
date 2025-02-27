class Exc6
{
    public static void Executar(){
        Console.WriteLine("Vamos calcular seu IMC:");

        Console.Write("Peso: ");
        double peso = double.Parse(Console.ReadLine()); 

        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine()); 

        double imc = peso / (altura * altura);

        if (imc < 18.5) {
            Console.WriteLine($"Seu IMC {imc:F2} - Abaixo do peso.");
        } else if (imc >= 18.5 && imc <= 24.9){
            Console.WriteLine($"Seu IMC {imc:F2} - Normal.");
        } else if (imc >= 25 && imc <= 29.9){
            Console.WriteLine($"Seu IMC {imc:F2} - Acima do Peso.");
        } else if (imc >= 30 && imc <= 34.9){
            Console.WriteLine($"Seu IMC {imc:F2} - Obeso 1.");
        } else if (imc >= 35 && imc <= 39.9){
            Console.WriteLine($"Seu IMC {imc:F2} - Obeso 2.");
        } else if (imc >= 40){
            Console.WriteLine($"Seu IMC {imc:F2} - Obesidade Morbida.");
        } else {
            Console.WriteLine("Erro ao calular,tente novamente.");
        }

    }
}