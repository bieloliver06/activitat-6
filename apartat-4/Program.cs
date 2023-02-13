namespace apartat_4
{
    class Program
    {
        static void Main()
        {
            string? input;
            // Cream un array de 10 edats
            int[] edats = new int[10];
            
            // Demanam les edats 10 pics
            for (int i = 0; i < edats.Length; i++)
            {
                System.Console.Write($"Introdueix l\'edat {i + 1}: ");
                input = System.Console.ReadLine();
                // Revisam que el que ha introduit l'usuari sigui un número
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

            // Ordenam les edats
            Array.Sort(edats);

            // Feim el total de les edats
            int total = edats.Sum();
            
            // Feim la mitjana de les edats
            Console.WriteLine($"La mitjana d\'edat és {total / edats.Length}");
            
            // Mostram les edats més gran i més petita
            Console.WriteLine($"La edat més gran és {edats[edats.Length - 1]}");
            Console.WriteLine($"La edat més petita és {edats[0]}");
        }
    }
}