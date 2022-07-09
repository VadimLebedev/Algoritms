using SelectionSorting;

var array = new[] { 3, 4, 2, 1, 11, 2, 786, 45, 345, 100 };

var sorted = SelectionSorting<int>.Sort(array);

Console.WriteLine(string.Join(',', sorted));