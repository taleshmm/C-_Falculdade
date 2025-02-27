class Exc9
{
    public static void Executar(){
        Console.Write("Digite o seu salário bruto: ");
        double salario = double.Parse(Console.ReadLine()); 

        double imposto;

        if (salario <= 1400){
            imposto = 0.075;
        } else if (salario > 1400 && salario <= 2700) {
            imposto = 0.09;
        } else if (salario > 2700 && salario <= 4000) {
            imposto = 0.12;
        } else {
            imposto = 0.14;
        }

        double valorDoImposto = salario * imposto;
        double salarioDeduzidoImposto = salario - valorDoImposto;

        Console.WriteLine($"Seu salário após a dedução do imposto é de R$ {salarioDeduzidoImposto:F2}, o bruto é R$ {salario:F2} e o valor dos impostos é de R$ {valorDoImposto:F2}");

    }
}