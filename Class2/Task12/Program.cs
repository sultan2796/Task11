using Task12;

int x = 35;
int y = 56;
int c = 67;
string text = "salamaa";

bool result = Extention.IsOdd(x);
bool result2 = y.IsOdd();
bool result3 = c.IsEven();
bool result4 = text.IsContain();
Console.WriteLine(result);
Console.WriteLine(result2);
Console.WriteLine(result3);
Console.WriteLine(result4);
Console.WriteLine(text.ToCaptalize());

foreach (var item in text.GetValueIndex('a'))
{
    if (item != -1)
    {
        Console.WriteLine(item);
    }
}




