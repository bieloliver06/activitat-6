namespace apartat_5
{
    class Program
    {
        static void Main()
        {
            int a = 0;
            int e = 0;
            int i = 0;
            int o = 0;
            int u = 0;
            Console.WriteLine("Introdueix un text:");
            string? input = Console.ReadLine();
            if (input != null)
            {
                char[] text = input.ToCharArray(); 
                for (int j = 0; i < text.Length - 1; j++) 
                { 
                    if (text[i] == 'a')
                    {
                        a++;
                    }
                    else if (text[i] == 'e')
                    {
                        e++;
                    }
                    else if (text[i] == 'i')
                    {
                        i++;
                    }
                    else if (text[i] == 'o')
                    {
                        o++;
                    }
                    else if (text[i] == 'u')
                    {
                        u++;
                    }
                }
                Console.WriteLine($"A apareix {a} vegades");
                Console.WriteLine($"E apareix {e} vegades");
                Console.WriteLine($"I apareix {i} vegades");
                Console.WriteLine($"O apareix {o} vegades");
                Console.WriteLine($"U apareix {u} vegades");
            }
            else Console.WriteLine("El que has introduit no és valid");    
        }
    }
}