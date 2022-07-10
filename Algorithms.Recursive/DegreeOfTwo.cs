namespace Algorithms.Recursive
{
    internal class DegreeOfTwo
    {
        public static bool Start(int x)
        {
            if (x == 1)
                return true;
            if (x % 2 != 0)
                return false;
            return Start(x / 2);
        }
    }
}
