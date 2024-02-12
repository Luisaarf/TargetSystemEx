using System.Runtime.Serialization.Json;

namespace target_project.code {
    public class exercise3
    {
        public void Exercise3()
        {
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory() + @"\data\dados.json");
            var json = File.ReadAllText(System.IO.Directory.GetCurrentDirectory() + @"\data\dados.json");
            var js = new DataContractJsonSerializer(typeof(List<DailyBilling>));
            var ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json));
            // var dailyBilling = (List<DailyBilling>)js?.ReadObject(ms);
            var dailyBilling = new List<DailyBilling>();
            if (js != null && ms != null){
                #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                dailyBilling = (List<DailyBilling>)js.ReadObject(ms);
                #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            }

            if (dailyBilling != null && dailyBilling.Count > 0)
            {
                DailyBilling biggestDailyBilling = new DailyBilling();
                DailyBilling smallestDailyBilling = new DailyBilling();
                for(int i = 0; i < dailyBilling.Count; i++)
                {
                    //encontra o maior e menor faturamento diário
                    if(i == 0){
                        biggestDailyBilling = dailyBilling[i];
                        smallestDailyBilling = dailyBilling[i];
                    }
                    if(dailyBilling[i].valor > biggestDailyBilling.valor){
                        biggestDailyBilling = dailyBilling[i];
                    }
                    if(dailyBilling[i].valor < smallestDailyBilling.valor && dailyBilling[i].valor != 0.0){
                        smallestDailyBilling = dailyBilling[i];
                    }
                //retira dias com valor 0 
                    if(dailyBilling[i].valor == 0.0){
                        dailyBilling.RemoveAt(i);
                        i--;
                    }
                }
                double valuesum = 0;
                //calcular faturamento total
                for(int i = 0; i < dailyBilling.Count; i++)
                {
                    valuesum += dailyBilling[i].valor;

                }

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Maior faturamento diário:");
                Console.WriteLine("Dia: " + biggestDailyBilling.dia);
                Console.WriteLine("Valor: " + biggestDailyBilling.valor);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Menor faturamento diário:");
                Console.WriteLine("Dia: " + smallestDailyBilling.dia);
                Console.WriteLine("Valor: " + smallestDailyBilling.valor);
                Console.WriteLine("----------------------------------"); 
                double average = valuesum / dailyBilling.Count;
                Console.WriteLine("Faturamento médio:" + average );
                Console.WriteLine("Faturamento total: " + valuesum);
                // alternativa para calcular média: 
                // Console.WriteLine("Valor: " + dailyBilling.Average(x => x.valor));
                //calcula dias com faturamento acima da média
                int profitableDays=0;
                for(int i = 0; i < dailyBilling.Count; i++)
                {
                    if(dailyBilling[i].valor > average){
                        profitableDays++;
                    }
                }

                Console.WriteLine("Dias com faturamento acima da média: " + profitableDays);

            }
        }
    }
}