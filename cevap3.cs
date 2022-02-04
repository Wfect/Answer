using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Birinci sayiyi giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girilen sayi : " + sayi1);
        
        Console.Write("İkinci sayiyi giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girilen sayi : " + sayi2);

      
        Console.WriteLine("Numbers before displacement");
        Console.WriteLine("Sayı 1={0}",sayi1);
        Console.WriteLine("Sayı 2={0}", sayi2);
     
        
        sayi1 = sayi1 + sayi2;
        sayi2 = sayi1 - sayi2;
        sayi1 = sayi1 - sayi2;
        Console.WriteLine("___________________________________");
        Console.WriteLine("Numbers after displacement");
        Console.WriteLine("Sayı 1={0}", sayi1);
        Console.WriteLine("Sayı 2={0}", sayi2);
 
        Console.ReadKey();
    }
}