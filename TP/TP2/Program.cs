using System;

class Program {
    static void Main() {
        Console.Write("Escolha qual TP quer executar: ");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Exc1.Executar();
                break;
            case "2":
                Exc2.Executar();
                break;
            case "3":
                Exc3.Executar();
                break;
            case "4":
                Exc4.Executar();
                break;
            case "5":
                Exc5.Executar();
                break;
            case "6":
                Exc6.Executar();
                break;
            case "7":
                Exc7.Executar();
                break;
            case "8":
                Exc8.Executar();
                break;
            case "9":
                Exc9.Executar();
                break;
            case "10":
                Exc10.Executar();
                break;
            case "11":
                Exc11.Executar();
                break;
            case "12":
                Exc12.Executar();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

    }
}