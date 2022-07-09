using Algorithms.BinarySearch;

var massive = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
var value = 1;

var index = BinarySearch<int>.Search(massive, value);

Console.WriteLine(index);
