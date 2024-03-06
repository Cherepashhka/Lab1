using Newtonsoft.Json;
using System.Text.Json.Serialization;

//string s = File.ReadAllText(@"E:\L9\L1.txt");
//List<string> list = new List<string>();
//list.AddRange(s.Split(' '));
//for (int i = 0; i < list.Count; i++)
//{
//    list[i] = list[i].ToLower();
//}
//for (int i = 0; i < list.Count; i++)
//{
//    while (i != list.LastIndexOf(list[i]))
//    {
//        list.RemoveAt(list.LastIndexOf(list[i]));
//    }
//}
//foreach (string word in list)
//{
//    Console.Write(word + " ");
//}
//Console.WriteLine();





//Dictionary<string, int> d1 = new Dictionary<string, int> { { "item1", 400 } },
//                        d2 = new Dictionary<string, int> { { "item2", 300 } },
//                        d3 = new Dictionary<string, int> { { "item1", 750 } };
//Dictionary<string, int> finald = new Dictionary<string, int>();
//List<Dictionary<string, int>> listofdict = new List<Dictionary<string, int>>();
//listofdict.Add(d1);
//listofdict.Add(d2);
//listofdict.Add(d3);
//foreach (Dictionary<string, int> dX in listofdict)
//{
//    foreach (KeyValuePair<string, int> kvpair in dX)
//    {
//        if (finald.ContainsKey(kvpair.Key))
//            finald[kvpair.Key] += kvpair.Value;

//        else
//            finald.Add(kvpair.Key, kvpair.Value);
//    }
//}
//Console.WriteLine("Результат:");
//Console.Write("{");
//foreach (KeyValuePair<string, int> kvpair in finald)
//{
//    Console.Write($"'{kvpair.Key}': {kvpair.Value},");
//}
//Console.SetCursorPosition(Console.GetCursorPosition().Left - 1, Console.GetCursorPosition().Top);
//Console.WriteLine("}");
//string json = JsonConvert.SerializeObject(finald);
//File.WriteAllText("E:\\L9\\dict.json", json);




Dictionary<string, int> Food = new Dictionary<string, int>();
Food.Add("Apple", 60);
Food.Add("Banana", 100);
Food.Add("Meat", 250);
Food.Add("Cacao", 70);
Food.Add("Sugar", 120);
Food.Add("Carrot", 90);
var GroupOfLess100 = Food.Where(kp => kp.Value <= 100);
var GroupOfGreater100 = Food.Where(kp => kp.Value > 100);
Console.WriteLine("Group 1 (less than 100):");
foreach (var group in GroupOfLess100)
{
    Console.WriteLine(group);
}
Console.WriteLine("\nGroup 2 (greater than 100):");
foreach (var group in GroupOfGreater100)
{
    Console.WriteLine(group);
}