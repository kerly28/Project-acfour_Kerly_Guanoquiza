//PRE: EL programa demana introduïr 4 números naturals
using System;

namespace ExamenSorpresa
{
    public class Program
    {
        //metòde per verificar si el número introduït és natural
        public static bool Natural(int num)
        {
            return num > 0;
        }
        public static void Main()
        {
            //inici constants
            const string Msg = "Introdueix un número natural: ";
            //array per emmagatzemar els números
            int[] numbers = new int[4];
            //inici programa
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Msg);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                //Crideam al métode que comprova si el número és natural
                if (!Natural(numbers[i]))
                {
                    Console.WriteLine("Error: Has d'introduir un número natural.");
                    break;
                }
                else if (i == 3)
                {
                    Console.WriteLine("Els números introduïts són: ");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine(numbers[j]);
                    }
                }
            }

        }
    }
}
//POST: El programa mostra els 4 números introduïts


