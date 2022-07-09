namespace SelectionSorting
{
    internal class SelectionSorting<T> where T : IComparable<T>
    {
        public static IList<T> Sort(IList<T> source)
        {
            var lenght = source.Count;

            for (var i = 0; i < lenght; i++)
            {
                var minIndex = i;

                for (var j = i + 1; j < lenght; j++)
                {
                    if (source[j].CompareTo(source[minIndex]) < 0)
                        minIndex = j;
                }

                var tmp = source[i];
                source[i] = source[minIndex];
                source[minIndex] = tmp;
            }

            return source;
        }
    }
}
