using System.Text;

//string words = "maciek i chuj";




var s2 = new StringBuilder();

s2.AppendLine("Elo");
s2.Append("Maciek");
string s3 = s2.ToString();
Console.WriteLine(s3);

IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
Console.WriteLine("Last Element in intList: {0}", intList.LastOrDefault());

//foreach (var a in words.Split(','))
//{
//    Console.WriteLine(a);
//}

//string text = "Ala ma kota";

//foreach (var word in text.Split(','))
//{
//    Console.WriteLine(word);
//}

//string url = "https://www.example.com/some/path?query=123";
//string[] parts = url.Split(new char[] { ':', '/', '?' }, StringSplitOptions.RemoveEmptyEntries);

//string protocol = parts[0];
//string host = parts[1];
//string path = parts[2];
//string query = "";

//if (parts.Length > 3)
//{
//    query = parts[3];
//}

//Console.WriteLine("Protocol: " + protocol);
//Console.WriteLine("Host: " + host);
//Console.WriteLine("Path: " + path);
//Console.WriteLine("Query: " + query);

//string tekst = "Maciek to koks";


//Console.WriteLine("Co to jest : "+ string.IsNullOrEmpty(tekst));
//Console.WriteLine("Sprawdzam : " + string.IsNullOrWhiteSpace(tekst));

//string tekst2 = "";
//Console.WriteLine("Co to jest : " + string.IsNullOrEmpty(tekst2));
//Console.WriteLine("Sprawdzam : " + string.IsNullOrWhiteSpace(tekst2));

//string tekst3 = "Maciej Terminator";
//string tekst4 = tekst3.Substring(2,10);
//Console.WriteLine("Rezultat tego to : " + tekst4);


//// string.Substring zwraca część łańcucha od określonego indeksu, jeżeli ustalimy indeks 2 to od tego momentu zwróci tekst
//// substring(7,5) zacznie pobierać od indeksu 7 i pobierze 5 znaków
//// string.split rozdziela łańcuch znaków
//// string.IsNullOrEmpty string.IsNullOrWhiteSpace i Contains zwracają true albo false

//string s1 = "Maciek";
//s1 = s1 + " Dysput";


//Console.WriteLine(s1);