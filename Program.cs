using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipdonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("----------bilinçsiz dönüşüm--------------");
            //bilinçsiz dönüşüm

            byte a = 5;
            sbyte b = 30;
            short c =10;

            int d = a+b+c;
            Console.WriteLine("d:" + d);

            long h = d;
             Console.WriteLine("h:" + h);

             float i = h;
              Console.WriteLine("i:" + i);

              string e= "ali";
              char f= 'k';
              object g =e+f+d;
               Console.WriteLine("g:" + g);


               // bilinçli dönüşüm

                   Console.WriteLine("-----------------bilinçli dönüşüm---------");

                   int x=4;
                   byte y =(byte )x;
                          Console.WriteLine("y:"+y );

                          int z =100;
                          byte t= (byte )z;
                           Console.WriteLine("y:"+t );


                           float w =10.3f;
                           byte v = (byte )w;
                            Console.WriteLine("v:"+v );

                            // to string metodu 
                             Console.WriteLine("---------ToString Metodu---------");

                             int xx = 6;
                             string yy =xx.ToString ();
                              Console.WriteLine("yy:"+yy );

                              string zz = 12.5f.ToString();
                               Console.WriteLine("zz:"+zz );

                               // Convert sınıfı
                                Console.WriteLine("------------Convert Sınıfı-----" );

                                string s1 ="10", s2="20";
                                int sayı1,sayı2;
                                int toplam;

                                sayı1=Convert.ToInt32(s1);
                                sayı2=Convert.ToInt32 (s2);

                                toplam = sayı1 + sayı2 ;
                                 Console.WriteLine("Toplam :"+toplam  );

                                 // Parse 
                                  Console.WriteLine("-------Parse-----" );
                                  ParseMethod();

        }
                                  public static void ParseMethod()
                                  {
                                    string metin1 ="10";
                                    string metin2 ="10.25";
                                    int rakam1;
                                    double double1;

                                    rakam1 = Int32.Parse(metin1 );
                                    double1 = Double.Parse(metin2 );
                                     Console.WriteLine("double1:"+double1  );
                                     Console.WriteLine("rakam1"+rakam1  );


                                     // www.patika.dev
                                  
        }
    }
}
