/*Ejemplo de Sum
Devuelve la suma de los valores ingresados del la lista

var Num = new List<int> { 8, 2, 3, 6 };

int Sum = Num.Sum();

Console.WriteLine(Sum);*/

//--------------------------------------------------------

/*var Num = new List<double> { 8.1, 2.2, 6.1, 3.3 };

double Sum = Num.Sum();

Console.WriteLine(Sum);*/

//--------------------------------------------------------

/*var Num = new List<int>();
int Sum = Num.Sum();
Console.WriteLine(Sum);*/

//--------------------------------------------------------

/*var Num = new List<int?> { 8, 2, 3, null };

int? Sum = Num.Sum();

Console.WriteLine(Sum);*/

//--------------------------------------------------------

/*var List = new List<int> { 8, 2, 6, 3 };
int Sum = (from x in List select x).Sum();
Console.WriteLine(Sum);*/

//--------------------------------------------------------

/*var List = new List<int> { 8, 2, 6, 3 };
int Sum = (from x in List where x > 4 select x).Sum();
Console.WriteLine(Sum);*/

//--------------------------------------------------------

/*Max devuelve el maximo valor de una lista

var List = new List<int> { 8, 2, 6, 3 };
int Max = List.Max();
Console.WriteLine(Max);*/

//--------------------------------------------------------

/*var Num = new List<double> { 8.1, 2.2, 6.1, 3.3 };

double Max = Num.Max();

Console.WriteLine(Max);*/

//--------------------------------------------------------

//Devuelve error

/*var Num = new List<int>();
int Max = Num.Max();
Console.WriteLine(Max);*/

//--------------------------------------------------------

/*var letter = new List<string?> { "a", "b", "c" };
string Max = letter.Max(); 
Console.WriteLine(Max);*/

//--------------------------------------------------------

/*var List = new List<int> { 8, 2, 6, 3 };
int Max = (from x in List select x).Max();
Console.WriteLine(Max);*/

//--------------------------------------------------------

/*var List = new List<int> { 8, 2, 6, 3 };
int Max = (from x in List where x < 5 select x).Max();
Console.WriteLine(Max);*/

//--------------------------------------------------------

//Retorna el valor minimo 

/*var List = new List<int> { 8, 2, 6, 3 };
int Min = (from x in List select x).Min();
Console.WriteLine(Min);*/

//-------------------------------------------------------

/*var List = new List<int> { 8, 2, 6, 3 };
int Min = (from x in List where x > 5 select x).Min();
Console.WriteLine(Min);*/

//------------------------------------------------------

//Retorna cuantos elementos hay en la lista, funciona con cuaquier tipo de dato :3

/*var List = new List<int> { 8, 2, 6, 3 };
int Count = (from x in List select x).Count();
Console.WriteLine(Count);*/

//------------------------------------------------------

/*var List = new List<int> { 8, 2, 6, 3 };
int Count = (from x in List where x > 5 select x).Count();
Console.WriteLine(Count);*/

//------------------------------------------------------

/*IEnumerable<string> Items = new List<string> { "A", "B", "C" };
int count = Items.Count();
Console.WriteLine(count);*/

//------------------------------------------------------

//Average Calcula el valor promedio de la coleccion

//------------------------------------------------------

/*var List = new List<int> { 8, 2, 6, 3 };
double Average = (from x in List select x).Average();
Console.WriteLine(Average);*/

//------------------------------------------------------

/*var List = new List<int> { 8, 2, 6, 3 };
double Average = (from x in List where x > 5 select x).Average();
Console.WriteLine(Average);*/

//------------------------------------------------------

//Lambda

/*Func<int, int> square = x => x * x;
Console.WriteLine(square(5));*/

//------------------------------------------------------

int[] num = { 3, 4, 5, 6, 4, 5, 7 };
var NumMayores = num.Where(n => n > 5).ToList();
var NumPares = num.Where(n => n % 2 == 0).ToList();
var NumImpares = num.Where(n => n %  2 != 0).ToList();

foreach(int i in NumMayores)
{
    Console.Write($"{i} ");
}

Console.WriteLine();

foreach(int i in NumPares)
{
    Console.Write($"{i} ");
}

Console.WriteLine();

foreach(var i in NumImpares)
{
    Console.Write($"{i} ");
}