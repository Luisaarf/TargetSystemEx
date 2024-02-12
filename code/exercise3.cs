using System.Runtime.Serialization.Json;

namespace target_project.code {
    public class exercise3
    {
        public void Exercise3()
        {
            Console.WriteLine( System.IO.Directory.GetCurrentDirectory()+ @"\data\dados.json");
            var json = File.ReadAllText(System.IO.Directory.GetCurrentDirectory()+ @"\data\dados.json");
            var js = new DataContractJsonSerializer(typeof(List<DailyBilling>));
            var ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json));
            var dailyBilling = (List<DailyBilling>)js.ReadObject(ms);

            Console.WriteLine("Digite o dia que deseja consultar:");
            int day = Convert.ToInt16(Console.ReadLine());
            if(dailyBilling != null && dailyBilling.Count > 0){
                Console.WriteLine(dailyBilling[day].dia);
                Console.WriteLine(dailyBilling[day].valor);
            }
        }
    }
}