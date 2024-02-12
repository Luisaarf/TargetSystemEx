namespace target_project.code {
    public class exercise4
    {
        public void Exercise4()
        {
            Console.WriteLine("A ser implementado... ");
            float sp = 67836.43f;
            float rj = 36678.66f;
            float mg = 29229.88f;
            float es = 27165.48f;
            float outros = 19849.53f;
            float total = sp + rj + mg + es + outros;
            Console.WriteLine("Porcentagem de cada estado:");
            Console.WriteLine("SP: " + (sp * 100 / total) + "%");
            Console.WriteLine("RJ: " + (rj * 100 / total) + "%");
            Console.WriteLine("MG: " + (mg * 100 / total) + "%");
            Console.WriteLine("ES: " + (es * 100 / total) + "%");
            Console.WriteLine("Outros: " + (outros * 100 / total) + "%");

        }
    }
}
