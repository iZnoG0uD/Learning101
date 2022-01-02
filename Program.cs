var a = Console.ReadLine();
var b = Console.ReadLine();

object resultA = "";
object resultB = "";

switch (a)
{
    case "true":
        resultA = Convert.ToBoolean(a);
        break;
    case "false":
        resultA = Convert.ToBoolean(a);
        break;

}

switch (b)
{
    case "true":
        resultB = Convert.ToBoolean(b);
        break;
    case "false":
        resultB = Convert.ToBoolean(b);
        break;

}

if(int.TryParse(a, out int resultA1))
{
    resultA = resultA1;
}
else if(double.TryParse(a, out double resultA2))
{
    resultA = resultA2;
}

if (int.TryParse(b, out int resultB1))
{
    resultB = resultB1;
}
else if (double.TryParse(b, out double resultB2))
{
    resultB = resultB2;
}

var a2 = resultA;
var b2 = resultB;

if (a2.GetType() == b2.GetType())
    Console.WriteLine("Типы переменных одинаковые! Ура!");
else Console.WriteLine("Типы переменных неодинаковые!");

Console.WriteLine(a2.GetType());
Console.WriteLine(b2.GetType());
