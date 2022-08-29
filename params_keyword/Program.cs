using System;

namespace params_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int price = 59;
            char at = '@';
            float pi = 3.14f;
            string book = "House of";

            Params("fdsfds", "erewr", "htrhwjkuyrk", "kjmhgd", "y5wy", "hgfdh", "ytrwy", "iuyrki", "kjhf", "ngfdh", "ytre", "htr", ".");
            ParamsMethod(price, at, pi, book);
        }



        static void Params(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
            Console.WriteLine("\n");
        }

        //passing object
        static void ParamsMethod(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj + " ");
            }
            Console.ReadLine();
        }
    }
}
