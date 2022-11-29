namespace Pr_12._n1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 3, 1, 4 };
            Array.Sort(arr);
            if (arr.Length > 0)
            {
                Console.WriteLine("Минимальное число: " + arr[0]);
                Console.ReadKey();
            }
        }
    }
}