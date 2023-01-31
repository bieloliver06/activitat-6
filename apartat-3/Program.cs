namespace apartat_3
{
    class Program
    {
        static void Main()
        {
            int j = 0;
			Console.WriteLine("Introdueix un text:");
            string? input = Console.ReadLine();
            if (input != null)
            {
                char[] text = input.ToCharArray(); 
                for (int i = 0; i < text.Length - 1; i++) 
                { 
                    if (text[i] == 'a' && text[i+1] == 'u')
                    {
                        j++;
                    }
                }
                Console.WriteLine($"La combinació de les lletres \"au\" apareix {j} vegades");
            }
            else Console.WriteLine("El que has introduit no és valid");
        }
    }
}