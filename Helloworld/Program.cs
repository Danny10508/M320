namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[20];
            values[3] = 7;

            int[] values2 = new int[20];
            for (int i = 0; i < 20; i++)
            {
                values2[i] = values[i];
            }
            Console.WriteLine(values2[3]);

            Person p2 = new Person();
            Person[] perslist = new Person[20];

        }
    }
}
