using System.Collections;

namespace arrList;

class Program
{
    static void Main(string[] args)
    {
        //Kullanmak için System.Collections; Eklenmeli.
        ArrayList liste = new ArrayList();
        // liste.Add("Bedo");
        // liste.Add(2);
        // liste.Add(true);
        // liste.Add('a');

        //İçerisindeki elemanlara erişirken
        //Console.WriteLine(liste[1]);
        Console.WriteLine();

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        //AddRange
        Console.WriteLine("-----------------AddRange-------------------");
        Console.WriteLine();

        string [] renkler={"Siyah","Beyaz","Mavi","Mor","Koyu Mavi"};
        List<int> sayilar= new List<int>(){1,2,3,4,5,6,7,8,9,10};
        // liste.AddRange(renkler);
        liste.AddRange(sayilar);

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        //Sort
        Console.WriteLine("---------------Sort-------------------");
        liste.Sort(); //Bu hata verebilir çünkü içinde birbirinden farklı değer türleri var

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        // Binary Search
        // küçük bir dip not binary search de aradığınız elemanın indexi ni bulmak için öncesinde sort yapnaız gerekiyor.
        Console.WriteLine("---------------Binary Search------------------");
        Console.WriteLine(liste.BinarySearch(4));
        Console.WriteLine();

        //Reverse
        Console.WriteLine("----------------Reverse------------------");
        liste.Reverse();
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        //Clear
        Console.WriteLine("-----------------clear--------------");
        liste.Clear();
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        
    }
}
