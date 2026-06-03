using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal_sayi_kontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Kontrol edilecek sayıyı giriniz : ");
                long sayi = Convert.ToInt64(Console.ReadLine());

                bool asalmi = true;

                if( sayi < 2)
                {
                    
                    Console.WriteLine("2'den küçük sayılar asal sayı olamazlar.");
                    asalmi = false;
                }
                else
                {
                    for (long i = 2; i <= sayi/2; i++)
                    {
                        if ( sayi % i == 0)
                        {
                            asalmi = false;
                            break;
                        }
                    }
                }

                if (asalmi == true)
                {
                    Console.WriteLine("Girilen {0} sayısı asal bir sayıdır. ", sayi);
                }
                else
                {
                    Console.WriteLine("Girilen {0} sayısı asal bir sayı değildir. ", sayi);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : {0}", ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
