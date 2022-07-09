namespace Algorithms.BinarySearch
{
    internal class BinarySearch<T> where T : IComparable<T>
    {
        public static int Search(T[] data, T value)
        {
            var low = 0;
            var high = data.Length - 1;

            while (low <= high)
            {
                var mid = (low + high) / 2;
                var guess = data[mid];
                if (guess.CompareTo(value) == 0)
                    return mid;

                if (guess.CompareTo(value) > 0)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return -1;
        }
    }
}
