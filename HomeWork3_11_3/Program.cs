using HomeWork3_11_3;

var dc = new HomeWork3_11_3.Dictionary<string, int>();
dc.Add("1980", 10000);
dc.Add("1981", 10010);
//dc.Add("1981", 10020); // провокація помилки

var res = dc["1981"];  // тест індексера
