// See https://aka.ms/new-console-template for more information

int[] tablica = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var lol = tablica.Where(x => x > 5);
Console.WriteLine(String.Join(", ", lol));
Console.WriteLine("==");
var lol1 = from lol2 in tablica
           where lol2 > 5
           select lol2;
Console.WriteLine(String.Join(", ", lol1));


//int[] tablica = { 10, 1, 9, 2, 4, 3, 5, 6, 7, 8, 9 };
//List<int> numbersToSort = tablica.ToList();

//numbersToSort.Sort();

//int[] sortedNumber = new int[tablica.Length];

//for (int i = tablica.Length - 1; i >= 0; i--)
//{
//    sortedNumber[tablica.Length - 1 - i] = numbersToSort[i];
//}
//foreach (var item in sortedNumber)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("=");
//Console.WriteLine(string.Join(", " , sortedNumber));

//int[] tablica = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


//int max = tablica[0];
//int min = tablica[0];

//foreach (var item in tablica)
//{
//    if (item > max)
//    {
//        max = item;
//    }
//    if (item < min)
//    {
//        min = item;
//    }
//}
//Console.WriteLine(max);
//Console.WriteLine(min);


//for (int i = tablica.Length -1; i >= 0; i--)
//{
//    Console.WriteLine(tablica[i]);
//}


//int pierwszaLiczba = 0;
//int drugaLiczba = 1;
//int result = 0;

//for (int i = 2; i < 10; i++)
//{
//    result = pierwszaLiczba + drugaLiczba;
//    pierwszaLiczba = drugaLiczba;
//    drugaLiczba = result;
//    Console.WriteLine(result);
//}

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