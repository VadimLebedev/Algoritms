namespace Algorithms.Recursive
{
    internal class AccermanFunction
    {
        public static int Start(int m, int n)
        {
            if (m == 0)
                return n + 1;
            if (m > 0 && n == 0)
                return Start(m - 1, 1);

            return Start(m - 1, Start(m, n - 1));
        }
    }
}
