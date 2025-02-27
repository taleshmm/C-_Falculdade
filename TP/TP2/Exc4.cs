class Exc4 {
    public static void Executar(){
        Console.WriteLine("Por favor preencha o formulário:");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine()); 

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("E-mail: ");
        string email = Console.ReadLine();

        Console.WriteLine($"\n-----Confirme seus dados:----- \nNome: {nome} \nIdade: {idade} \nTelefone: {telefone} \nE-mail: {email}");
            }
}