using System;

namespace calculator{

    class Program{

        static void Main(string[] args){

            Console.WriteLine(">>>>Program Kalkulator Sederhana.<<<<\n");
            Console.WriteLine("Operator apa yang akan anda gunakan?\n1. +\n2. -\n3. *\n4. /");
            Console.Write("Pilihan anda = ");
            int c = Convert.ToInt32(Console.ReadLine());
            if(c<1||c>4){
                Console.WriteLine("Pilihan anda salah.");
                return;
            }

            Console.WriteLine("\nMasukkan dua nilai yang akan anda operasikan!");
            Console.Write("Nilai a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nHasil perhitungan = ");
            if(c==1){
            Console.WriteLine(tambah(a,b));
            }else if(c == 2){
            Console.WriteLine(kurang(a,b));
            }else if(c == 3){
            Console.WriteLine(kali(a,b));
            }else if(c == 4){
            Console.WriteLine(bagi(a,b));
            }

            return;
        }

        static int tambah(int a, int b){
            return(a + b);
        }

        static int kurang(int a, int b){
            return(a - b);
        }

        static int kali(int a, int b){
            return(a * b);
        }

        static int bagi(int a, int b){
            return(a / b);
        }

    }

}