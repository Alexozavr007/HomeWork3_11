using HomeWork3_11_6;
using System.Collections;

var arrList = new ArrayList();

arrList.Add(new StructTest { Title = "Bol" });
arrList.Add(new Test { Title = "Kol" });

for (int i = 0; i < arrList.Count; i++) {
    var x = arrList[i];
    if (x is Test) {
        var test = (Test)x;
        Console.WriteLine($"ref type item: {test.Title}");
    } else if (x is StructTest) {
        var sTest = (StructTest)x;
        Console.WriteLine($"struct type item: {sTest.Title}");
    }
}