using System.Globalization;

class Exc1 {

 public static void Executar()
    {
   Console.Write("Digite sua data de nascimento no formato DD/MM/AAAA: ");
   string dataNasc = Console.ReadLine();

   DateTime dataNascConvertida;
   string formatar = "dd/MM/yyyy";
  

   if (DateTime.TryParseExact(dataNasc, formatar, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascConvertida)) {

    DateTime hoje = DateTime.Today;

    int anos = hoje.Year - dataNascConvertida.Year;
    int meses = hoje.Month - dataNascConvertida.Month;
    int dias = hoje.Day - dataNascConvertida.Day;

    if (dias < 0){
        meses--;
        dias += DateTime.DaysInMonth(hoje.Year,(hoje.Month == 1 ? 12 : hoje.Month - 1));
    }

    if (meses < 0) {
        anos--;
        meses += 12;
    }
   
   Console.WriteLine($"Idade: {anos} anos, {meses} meses e {dias} dias.");

   } else {
    Console.WriteLine("Data no formato inválido");

   }

    }

}