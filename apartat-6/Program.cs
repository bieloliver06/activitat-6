namespace apartat_6
{
    class Program
    {  
        static void Main()
        {
            Console.WriteLine("Introdueix un text: ");
            string? input = Console.ReadLine();
            if (input != null)
            {
                char[] array = input.ToLower().ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = (char)(array[i] - 32);
                }
                string output = new string(array);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("No s'ha introduït cap text");
            }
        }
    }
}