using System;

namespace alanhesaplamaodev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, sonuc;
            float pi = 3.14f;

            Console.WriteLine("üçgen alanı hesaplamak için 1'e basınız");
            Console.WriteLine("kare alanı hesaplamak için 2'e basınız");
            Console.WriteLine("daire alanı hesaplamak için 3'e basınız");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Alan mı hesaplayacaksınız çevre mi ?");
                secim = Console.ReadLine();

                if (secim == "alan")
                {
                    ///üçgen alanı hesapla 
                    Console.WriteLine("üçgenin taban uzunluğunu giriniz");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("üçgenin yüksekliğini giriniz");
                    b = Convert.ToInt32(Console.ReadLine());
                    sonuc = (a * b) / 2;
                    Console.WriteLine("Sonucunuz = " + sonuc);

                }
                else if (secim == "çevre")
                {
                    ///üçgen çevre hesapla 
                    Console.WriteLine("üçgenin bir kenar uzunluğunu giriniz");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("üçgenin 2. kenar uzunluğunu giriniz");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("üçgenin 3. kenar uzunluğunu giriniz");
                    c = Convert.ToInt32(Console.ReadLine());
                    sonuc = (a + b + c);
                    Console.WriteLine("Sonucunuz = " + sonuc);

                }

            }

            else if (secim == "2")
            {
                ///kare alanı hesapla
                Console.WriteLine("karenin bir kenar uzunluğunu giriniz");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Alan Sonucunuz = " + a * a);
                Console.WriteLine("Çevre Sonucunuz = " + a * 4);

            }
            else if (secim == "3")
            {
                ///daire alanı hesapla
                Console.WriteLine("dairenin yarıçap uzunluğunu giriniz");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Alan Sonucunuz = " + a * a * pi);
                Console.WriteLine("Çevre Sonucunuz = " + 2 * pi * a);

            }
            else
            {

                Console.WriteLine("yanlış seçim yaptınız");

            }
        }
    }
}





