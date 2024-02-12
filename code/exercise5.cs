namespace target_project.code{
    public class exercise5
    {
        public void Exercise5()
        {
            //Digite uma string e devolva a string invertida
            Console.WriteLine("Digite uma string para inverter:");
            string input = Console.ReadLine() ?? "";
            if (input == null || input.Length == 0)
            {
                Console.WriteLine("Nenhuma string foi digitada");
                return;
            }

            char[] charArray = input.ToCharArray();
            int left = 0;
            int right = charArray.Length - 1;
            while (left < right)
            {
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;
                left++;
                right--;
            }
            Console.WriteLine("String invertida: " + new string(charArray));
        }
    }
}