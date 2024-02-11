namespace target_project.code {
    public class exercise2
    {
        public void Exercise2()
        {
            Console.WriteLine("Digite um valor para verificar se ele está presente na sequência de Fibonacci");
            int value = Convert.ToInt16(Console.ReadLine());
            if (value == 0)
            {
                Console.WriteLine("O valor 0 está presente na sequência de Fibonacci");
                return;
            }
            if(value < 0)
            {
                Console.WriteLine("O valor " + value + " não está presente na sequência de Fibonacci");
                return;
            }
            // (0, 1, 1, 2, 3, 5, 8, 13, 21, 34...)
            int a = 0;
            int c = 0;
            int b =1;
            for(int i = 0; b <= value; i++)
            {
                if(i%2 == 0)
                {
                    c = b;
                    b = a + b;
                }
                else
                {
                    a = b;
                    b = c + b;
                }
                if(b == value)
                {
                    Console.WriteLine("O valor " + value + " está presente na sequência de Fibonacci");
                    return;
                }
            }
            Console.WriteLine("O valor " + value + " não está presente na sequência de Fibonacci");
            // return;
                    
        }
    }
}