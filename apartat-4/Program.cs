namespace apartat_4
{
    class Program
    {
        static void Main()
        {
            string? input;
            int[] edats = new int[10];
            for (int i = 0; i < edats.Length; i++)
            {
                System.Console.Write($"Introdueix l\'edat {i + 1}: ");
                input = System.Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        edats[i] = int.Parse(input);
                    }
                    catch (System.FormatException)
                    {
                        i--;
                    }
                }
                else i--;
            }

            Array.Sort(edats);
            
            int total = 0;
            for (int j = 0; j < edats.Length; j++)
            {
                total = total + edats[j];
            }
            Console.WriteLine($"La mitjana d\'edat és {total / edats.Length}");
            Console.WriteLine($"La edat més gran és {edats[edats.Length - 1]}");
            Console.WriteLine($"La edat més petita és {edats[0]}");
        }
    }
}