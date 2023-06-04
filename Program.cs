using System.Text.Json.Nodes;

namespace pra_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first Question
            /*Console.Write("Start Number: ");
            int a = int.Parse (Console.ReadLine());

            Console.Write("End Number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("=========================");
            Console.WriteLine();

            for(int i=a;  i <= b ; i+=2)
            {
                
                Console.WriteLine(i);
                
            }
            */

            // second Question

            {
                int number;
                Console.Write("Please Enter a Number: ");
                number = int.Parse(Console.ReadLine());

                int j = 1;
                for(int i = 1; i <= number; i++)
                {
                    j = j * i;
                }
                Console.WriteLine(j);
            }
        }
    }
}