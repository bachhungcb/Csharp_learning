String[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Toyota" };
//String[] cars  = new String[5];

cars[0] = "Opel";

//for (int i = 0; i < cars.Length; i++)
//{
//    Console.WriteLine(cars[i]);
//}

foreach(String car in cars)
{
    Console.WriteLine(car);
}

Console.ReadKey();