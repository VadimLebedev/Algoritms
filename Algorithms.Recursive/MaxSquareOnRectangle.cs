namespace Algorithms.Recursive
{
    internal class MaxSquareOnRectangle
    {
        public static int Start(int a, int b)
        {
            var remains = a > b ? a % b : b % a;
            if (remains == 0)
                return a > b ? b : a;

            return Start(a > b ? b : a , remains);
        }
    }
}
