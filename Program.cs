using System;

namespace tahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            int sabit = 60;
            int sayi;
            int sayac = 0;

            do
            {
                sayac = sayac + 1;
                Console.WriteLine(sayac + ". Sayıyı girin: ");
                sayi = int.Parse(Console.ReadLine());

                if (sayi < sabit && sayac < 7)
                {
                    Console.WriteLine("Daha büyük bir sayı girin ");
                }
                else if (sayi > sabit && sayac < 7)
                {
                    Console.WriteLine("Daha küçük bir sayı girin ");
                }

            } while (sabit != sayi && sayac < 7);

            if (sabit == sayi)
            {
                Console.WriteLine("Kazandın");
            }
            else
            {
                Console.WriteLine("Kaybettiniz");
            }

            Console.ReadKey();
        }
    }
}
