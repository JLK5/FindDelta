float a, b, c, delta, x1, x2;
string text;
bool result;

Console.WriteLine("Dla róniania kwadratowego o postaci ax^2 + bx = c podaj wartości: ");
Console.WriteLine("Wyraz a ");
text = Console.ReadLine();
result = float.TryParse(text, out a);  

if(!result)
{
    a = 1;
}

Console.WriteLine("Wyraz b ");
text = Console.ReadLine();
result = float.TryParse(text, out b);
if(!result) b = 1;

Console.WriteLine("Wyraz c ");
text = Console.ReadLine();
result = float.TryParse(text, out c);
if (!result) c = 1;

delta = b * b - 4 * a * c;

if(delta > 0)
{
    x1 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
    x2 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine("2 miejsca zerowe";
    Console.WriteLine("x1 wynosi: " + x1.ToString());
    Console.WriteLine("x2 wynosi: " + x2.ToString());
}
else if(delta == 0)
{
    x1 = (-b) / (2 * a);
    Console.WriteLine("jedno miejsce zerowe");
    Console.WriteLine("x1 wynosi: " + x1.ToString());
}
else
{
    Console.WriteLine("Brak miejsc zerowych");
}