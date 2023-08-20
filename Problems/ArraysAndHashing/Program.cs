using ArraysAndHashing;

var problem01 = new Problem01();
var result = problem01.ContainsDuplicate(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

Console.WriteLine(result);