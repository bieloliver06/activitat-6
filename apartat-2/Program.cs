namespace apartat_2
{
    class Program
    {
        static void Main()
        {
            char? letter;
            int j = 0;
            Console.WriteLine("Introdueix un text:");
            string? input = Console.ReadLine();
            if (input != null)
            {
                char[] text = input.ToCharArray(); 
                Console.WriteLine("Introdueix una lletra:");
                input = Console.ReadLine();
                if (input != null)
                {
                    letter = input[0];
                }
                else letter = null;
                for (int i = 0; i < text.Length; i++) 
                { 
                    if (text[i] == letter) 
                    { 
                        j++; 
                    }
                }
                Console.WriteLine($"La lletra {letter} apareix {j} vegades");
            }
            else Console.WriteLine("El que has introduit no és valid");
        }
    }
}