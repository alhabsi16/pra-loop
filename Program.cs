namespace pra_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Start Number: ");
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

        }
    }
}