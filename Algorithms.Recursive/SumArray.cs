namespace Algorithms.Recursive
{
    internal class SumArray
    {
        public static int Start(int[] values)
        {
            if (values.Length == 0)
                return 0;

            return values[0] + Start(values.Skip(1).ToArray());
        }
    }
}
