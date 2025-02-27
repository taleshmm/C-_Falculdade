using System.Globalization;

class Exc3
{
    public static void Executar(){
        Console.WriteLine("Vamos descobrir quantos dias tem entre duas datas (formato: dd/mm/aaaa) \n - Digite a primeira data: ");
        string data1 = Console.ReadLine();

        Console.WriteLine("Digite a segunda data: ");
        string data2 = Console.ReadLine();

       if(string.IsNullOrEmpty(data1) || string.IsNullOrEmpty(data2)) {
            Console.WriteLine("Você não digitou corretamente.");
            return;
         }
        string formatar = "dd/MM/yyyy";

        DateTime data1Convertida;
        DateTime data2Convertida;
        
        bool checkData1 = DateTime.TryParseExact(data1, formatar, CultureInfo.InvariantCulture, DateTimeStyles.None, out data1Convertida);
        bool checkData2 = DateTime.TryParseExact(data2, formatar, CultureInfo.InvariantCulture, DateTimeStyles.None, out data2Convertida);

        if (checkData1 && checkData2) {
            if (data1Convertida > data2Convertida){
                DateTime temp = data1Convertida;
                data1Convertida = data2Convertida;
                data2Convertida = temp;
            }

            TimeSpan diferencaDeDias = data2Convertida - data1Convertida;

            int anos = data2Convertida.Year - data1Convertida.Year;
            int meses = data2Convertida.Month - data1Convertida.Month;
            int dias = data2Convertida.Day - data1Convertida.Day;

            if (dias < 0){
                meses--;
                dias += DateTime.DaysInMonth(data2Convertida.Year, data2Convertida.Month == 1 ? 12 : data2Convertida.Month - 1);
            }

            if (meses < 0){
                anos--;
                meses += 12;
            }
             Console.WriteLine($"A diferença total em dias é de {diferencaDeDias.Days}.");
             Console.WriteLine($"A diferença entre as duas datas é de {anos} anos, {meses} meses ou {dias} dias.");
        }     
    
    }
}

