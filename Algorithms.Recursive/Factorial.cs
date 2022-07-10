namespace Algorithms.Recursive
{
    internal class Factorial
    {
        public static int Start(int x)
        {
            if (x == 1)
                return x;
            
            return x * Start(--x);
        }
    }
}
