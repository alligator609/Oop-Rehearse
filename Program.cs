using System.Collections;

// boxing  and not type safe
var list1 = new ArrayList();
list1.Add(1);
list1.Add("Mosh");
list1.Add(DateTime.Today);

foreach (var item in list1)
    Console.WriteLine(item);



// Unboxing and type safe
var list2 = new List<string>();
list2.Add("zia");
list2.Add("Mosh");
list2.Add("me");

foreach (var item in list2)
    Console.WriteLine(item);
