using Event_Extesion_Methods;
using Google.Protobuf;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Action<string,int> action = (string b ,int a) => Console.WriteLine(b+", Тест № 1 ,"+a);
action += (string a, int b) => Console.WriteLine(a+ ", Тест № 2 ," + b);
action += (string a, int b) => Console.WriteLine(a + ", Тест № 3 ," + b);
action("aa", 1);

Func<int, double, string> func = (int a, double b) => (a + b).ToString();
Console.WriteLine(func(5, 5)); 
func += (int a, double b) => (a - b).ToString();
Console.WriteLine(func(5, 5)); 
func += (int a, double b) => (a * b).ToString();
Console.WriteLine(func(5, 5)); 

Predicate<int> predicate = (int a) => a == 5;
Console.WriteLine(predicate(5));
    predicate += (int b) => b > 5;
Console.WriteLine(predicate(6));
    predicate += (int c) => c < 5;
Console.WriteLine(predicate(7));

bool b = true;
int i = b.ToInt();
Console.WriteLine(i);

string date = "12,11,2022";
DateTime dateTime = date.ToDate();
Console.WriteLine(dateTime.ToString());

double d = 6.5;
int g = d.ToInt();
Console.WriteLine(g);