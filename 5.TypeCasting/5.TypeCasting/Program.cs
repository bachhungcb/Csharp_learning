// See https://aka.ms/new-console-template for more information
//type casting  = Converting a value to a different data type 
//                Usefull when you want to convert a value to a different data type

double a = 3.14;
int b = Convert.ToInt32(a);
int c = 1243;
double d = Convert.ToDouble(c) + 0.1;
int i = 21321;
string f = Convert.ToString(i);

string g = "f";
char h = Convert.ToChar(g);

string j = "true";
bool k = Convert.ToBoolean(j);

Console.WriteLine(k);

Console.WriteLine(f.GetType());
Console.WriteLine(f);

