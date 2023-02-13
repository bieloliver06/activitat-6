namespace apartat_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introdueix una paraula:");
            string? input = Console.ReadLine();
            if (input != null)
            {
                char[] word = input.ToCharArray();
                for (int i = 0; i < word.Length; i++)
                {
                    Console.WriteLine(word[i]);
                }
            }
            else Console.WriteLine("El que has introduit no és valid");
        }   
    }
}