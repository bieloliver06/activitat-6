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
                Console.WriteLine("Introdueix una lletra:");
                letter = Console.ReadLine().Trim()[0];
                char[] text = input.ToCharArray(); 
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