
//var numbers = new List<int> { 1, 2, 3, 4, 5 };
//var result = numbers.Skip(2); // [3, 4, 5]


//Console.WriteLine("The result is {0}",result);

//var numbers2 = new List<int> { 1, 2, 3, 4, 5 };
//var result2 = numbers.SkipWhile(n => n < 3); // [3, 4, 5]
//Console.WriteLine(result2);

IList<string> strList = new List<string>() {
                                            "One",
                                            "Two",
                                            "Three",
                                            "Four",
                                            "Five",
                                            "Six"  };

var result = strList.SkipWhile(s => s.Length < 5);

foreach (string str in result)
    Console.WriteLine(str);

Console.WriteLine("\n\nELO\n\n");


IList<string> strList2 = new List<string>() {
                                            "One",
                                            "Two",
                                            "Three",
                                            "Four",
                                            "Five",
                                            "Six"  };

var result2 = strList2.SkipWhile((s, i) => s.Length > i);

var result3 = strList2.Where(s => s.Length > 4);

foreach (string str3 in result3)
    Console.WriteLine(str3);

//foreach (string str2 in result2)
//    Console.WriteLine(str2);

//Console.WriteLine(strList2.FirstOrDefault()); //one
//Console.WriteLine(strList2.FirstOrDefault(n=> n.Length > 2)); //One
//Console.WriteLine(strList2.SingleOrDefault(n=> n.Length == 5)); // three
////Console.WriteLine(strList2.SingleOrDefault(n => n.Length > 2)); //wyjątek
//Console.WriteLine(strList2.SingleOrDefault()); 
foreach (var resultitems in result2.Take(3).Skip(2))
{
Console.WriteLine(resultitems);
}


