// See https://aka.ms/new-console-template for more information

int[] tablica = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


int pierwszaLiczba = 0;
int drugaLiczba = 1;
int result = 0;

for (int i = 2; i < 10; i++)
{
    result = pierwszaLiczba + drugaLiczba;
    pierwszaLiczba = drugaLiczba;
    drugaLiczba = result;
    Console.WriteLine(result);
}

//int position = 10;
//string lol = "";
//for (int i = 0; i < tablica.Length; i++)
//{
//    if (tablica[i] == position)
//    {
//        lol = $"Pozycja {i}";
//        break;
//    }
//    else
//    {
//        lol = $"Nie ma takiej liczby";
//    }
//}
//Console.WriteLine(lol);



//int left = 0;
//int right = tablica.Length;
//int position = -11;
//string lol = "";
//while (left < right)
//{
//    int mid = (left + right) / 2;
//    if (tablica[mid] == position)
//    {
//        lol = $"Pozycja {mid}";
//        break;
//    }
//    else if (tablica[mid] > position)
//    {
//        right = mid;
//    }
//    else
//    {
//        left = mid + 1;
//    }
//    lol = $"Nie ma takiej liczby!";
//}
//Console.WriteLine(lol);



//int[] tablica = new int[] { 20, 25, 10, 11, 2, 3, 9, 5, 6, 1 };

//for (int i = 0; i < tablica.Length - 1; i++)
//{
//    for (int j = 1 + i; j < tablica.Length; j++)
//    {
//        if (tablica[i] > tablica[j])
//        {
//            int temp = tablica[i];
//            tablica[i] = tablica[j];
//            tablica[j] = temp;
//        }
//    }

//}
//Console.WriteLine("==");
//foreach (var item in tablica)
//{
//    Console.WriteLine(item);
//}


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