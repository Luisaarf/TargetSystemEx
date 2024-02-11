namespace target_project.code {
    public class exercise1
    {
        public void Exercise1()
        {
            Console.WriteLine("Valor da soma depois do loop");
            int soma = 0;
            for(int k = 1; k < 13; k++)
            {
                soma += k;
            }
            Console.WriteLine(soma);
        }
    }
}