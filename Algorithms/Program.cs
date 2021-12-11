// See https://aka.ms/new-console-template for more information

int[] tablica = new int[] { 20, 25, 10, 11, 2, 3, 9, 5, 6, 1 };

for (int i = 0; i < tablica.Length - 1; i++)
{
    for (int j = 1 + i; j < tablica.Length; j++)
    {
        if (tablica[i] > tablica[j])
        {
            int temp = tablica[i];
            tablica[i] = tablica[j];
            tablica[j] = temp;
        }
    }

}
Console.WriteLine("==");
foreach (var item in tablica)
{
    Console.WriteLine(item);
}


//for (int i = 1; i < 100; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0)
//    {
//        Console.WriteLine($"{i} FizzBuzz");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine($"{i} Fizz");
//    }
//    else if (i % 5 == 0)
//    {
//        Console.WriteLine($"{i} Buzz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }

//}