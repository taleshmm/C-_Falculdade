using System.Globalization;

class Exc2 {
     public static void Executar() {
        Console.Write("Vamos descobrir quantos dias falta para o seu aniversário \n - Digite sua data de nascimento: dd/mm/aaaa: ");
        string dataNasc = Console.ReadLine();

        DateTime dataNascConvertida;
        string formatar = "dd/MM/yyyy";

        if(DateTime.TryParseExact(dataNasc, formatar, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascConvertida)){

            DateTime hoje = DateTime.Today;
            DateTime proximoAniversario = new DateTime(hoje.Year, dataNascConvertida.Month, dataNascConvertida.Day);

          if (hoje.Month > dataNascConvertida.Month || (hoje.Month == dataNascConvertida.Month && hoje.Day > dataNascConvertida.Day))
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            TimeSpan diferancaDeDias = proximoAniversario - hoje;
            int falta  = diferancaDeDias.Days;
            Console.WriteLine($"Resta {falta} dia(s) para o seu aniversário.");

        } else {
            Console.WriteLine("Data no formato inválido.");
        }
    }
}