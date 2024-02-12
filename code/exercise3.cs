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
                dailyBilling = (List<DailyBilling>)js.ReadObject(ms);
            }

            // Console.WriteLine("Digite o dia que deseja consultar:");
            // int day = Convert.ToInt16(Console.ReadLine());
            if (dailyBilling != null && dailyBilling.Count > 0)
            {
                DailyBilling biggestDailyBilling = new DailyBilling();
                //retira dias com valor 0 
                for(int i = 0; i < dailyBilling.Count; i++)
                {
                    if(dailyBilling[i].valor > biggestDailyBilling.valor){
                        biggestDailyBilling = dailyBilling[i];
                    }
                    if(dailyBilling[i].valor == 0.0){
                        dailyBilling.RemoveAt(i);
                        i--;
                    }
                }

                Console.WriteLine(biggestDailyBilling.dia);
                Console.WriteLine(biggestDailyBilling.valor);

            }
        }
    }
}