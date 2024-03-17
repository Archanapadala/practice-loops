
namespace practice_loops
{
    internal class loops1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            for (int i = 1; i <= 10; i++)
            {
                res = num * i;
                //Console.WriteLine(num +" * "+i+" = "+res);
                Console.WriteLine($"{num} * {i} = {res}");
            }

        }
    }
}
