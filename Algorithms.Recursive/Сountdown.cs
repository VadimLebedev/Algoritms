namespace Algorithms.Recursive
{
    internal class Сountdown
    {
        public static void Start(int startNumber)
        {
            Console.WriteLine(startNumber);

            if (startNumber <= 0)
                return;
            
            Start(--startNumber);
        }
    }
}
