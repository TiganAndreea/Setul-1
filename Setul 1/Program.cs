using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1
{
    internal class Program
    {
        static void p1()
        {
            //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine(-b / a);
            Console.ReadKey();
        }
        static void p2()
        {
            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
            float a, b, c;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            float d, x1, x2;
            d = b * b - 4 * a * c;
            if (d >= 0)
            {
                x1 = (-b + (float)Math.Sqrt(d)) / (2 * a);
                x2 = (-b - (float)Math.Sqrt(d)) / (2 * a);
                Console.WriteLine(x1 + " " + x2);
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutii");
            }
            Console.ReadKey();
        }
        static void p3()
        {
            //Determinati daca n se divide cu k, unde n si k sunt date de intrare.
            int n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine("n se divide cu k");
            }
            else
            {
                Console.WriteLine("n nu se divide cu k");
            }
            Console.ReadKey();
        }
        static void p4()
        {
            //Detreminati daca un an y este an bisect
            int y = int.Parse(Console.ReadLine());
            if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
            {
                Console.WriteLine(y + " " + " este an bisect");
            }
            else
            {
                Console.WriteLine(y + " " + "nu este an bisect");
            }
            Console.ReadKey();
        }
        static void p5()
        {
            //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.
            int n, k, a, m, j;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            m = n;
            j = k;
            while (k > 1)
            {
                n = n / 10;
                k--;
            }
            if (k <= 1)
            {
                a = n % 10;
                Console.WriteLine($"A {j}-a cifra a lui {m} este {a}");
            }
        }
        static void p6()
        {
            //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("{0}, {1} si {2} pot fi laturile unui triunghi", a, b, c);
            }
            else
            {
                Console.WriteLine("{0},{1} si {2} nu pot fi faturile unui triunghi", a, b, c);
            }
        }
        static void p7()
        {
            //(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"{a}, {b}");
        }
        static void p8()
        {
            //(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"{a}, {b}");
        }
        static void p9()
        {
            //Afisati toti divizorii numarului n. 
            int n = int.Parse(Console.ReadLine());
            for (int d = 2; d <= n; d++)
            {
                if (n % d == 0)
                    Console.WriteLine(d);
            }
        }
        static void p10()
        {
            //Test de primalitate: determinati daca un numar n este prim.
            int n = int.Parse(Console.ReadLine());
            if (n == 2)
            {
                Console.WriteLine("Este prim");
            }
            if (n == 1)
            {
                Console.WriteLine("Nu este prim");
            }
            for (int d = 2; d <= Math.Sqrt(n); d++)
            {
                if (n % d == 0)
                {
                    Console.WriteLine("Nu este prim");
                }
            }
        }
        static void p11()
        {
            //Afisati in ordine inversa cifrele unui numar n. 
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                Console.WriteLine(n % 10);
                n = n / 10;
            }
        }
        static void p12()
        {
            //Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].
            int nr = 0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                    nr++;
            }
            Console.WriteLine(nr);
        }
        static void p13()
        {
            //Determianti cati ani bisecti sunt intre anii y1 si y2.
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = y1; i <= y2; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 && i % 400 != 0)
                {
                    nr++;
                }
            }
            Console.WriteLine(nr);
        }
        static void p14()
        {
            //Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
            int n = int.Parse(Console.ReadLine());
            int inv = 0;
            int a = n;
            while (n != 0)
            {
                inv = inv * 10 + n % 10;
                n = n / 10;
            }
            if (inv == a)
            {
                Console.WriteLine("Numarul este palindrom");
            }
            else
                Console.WriteLine("Numarul nu este palindrom");
    }
        static void p15()
        {
            //Se dau 3 numere. Sa se afiseze in ordine crescatoare.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int aux = 0;
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            Console.WriteLine(a + " " + b + " " + c);
        }
        static void p16()
        {
            //Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
            string[] t = Console.ReadLine().Split(' ');
            int a = int.Parse(t[0]);
            int b = int.Parse(t[1]);
            int c = int.Parse(t[2]);
            int d = int.Parse(t[3]);
            int e = int.Parse(t[4]);
            int aux = 0;
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (a > d)
            {
                aux = a;
                a = d;
                d = aux;
            }
            if (a > e)
            {
                aux = a;
                a = e;
                e = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (b > d)
            {
                aux = b;
                b = d;
                d = aux;
            }
            if (b > e)
            {
                aux = b;
                b = e;
                e = aux;
            }
            if (c > d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            if (c > e)
            {
                aux = c;
                c = e;
                e = aux;
            }
            if (d > e)
            {
                aux = d;
                d = e;
                e = aux;
            }
            Console.WriteLine("Numerele in ordine crescatoare sunt: " + a + "," + b + "," + c + "," + d + "," + e);
        }
        static void p17()
        {
            //Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
            string[] t = Console.ReadLine().Split(' ');
            int a = int.Parse(t[0]);
            int b = int.Parse(t[1]);
            int r = 0;
            int a1 = a;
            int b1 = b;
            int cmmmc = 0;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine("Cel mai mare divizor comun este " + a);
            cmmmc = (a1 * b1) / a;
            Console.WriteLine("Cel mai mic multiplu comun este " + cmmmc);
        }
        static void p18()
        {
            //Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 
            int n = int.Parse(Console.ReadLine());
            int d = 2;
            int p = 0;
            int ok = 0;
            while (n != 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    n = n / d;
                    p++;
                }
                if (p > 0 && ok == 1)
                {
                    Console.Write("+" + d + "^" + p);
                }
                if (p > 0 && ok == 0)
                {
                    Console.Write(d + "^" + p);
                    ok = 1;
                }
                d++;
            }
        }
        static void p19()
        {
            //Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[10];
            int temp = n;
            int s = 0;
            while (temp > 0)
            {
                int aux = temp % 10;
                a[aux]++;
                temp /= 10;
            }
            for (int i = 0; i < 10; i++)
            {
                if (a[i] != 0)
                    s++;
            }
            if (s == 2)
                Console.WriteLine("Numarul " + n + " este format din doua cifre care se repeta");
            else
                Console.WriteLine("Numarul " + n + " nu este format din doua cifre care se repeta");
        }
        static void p20()
        {
            //Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs)
            //O fractie este neperiodica daca numitorul este de forma 2 ^ m * 5 ^ n unde m si n sunt mai mari sau egale decat 0
            //O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5.
            //O fractie este periodica mixta daca se divide cu 2 si / sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5.
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int parteInt, parteFract;
            parteInt = m / n;
            parteFract = m % n;
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }

        }
        static void p21()
        {
            //Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?".
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int j = 1024;
            while (j != n)
            {
                Console.WriteLine($"Este {n} mai mare decat {i} si mai mic decat {j / 2}? ");
                if (n > i && n < j / 2)
                {
                    j = j / 2;
                }
                else
                {
                    i = i++;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul problemei:");
            int nrp = int.Parse(Console.ReadLine());
            if (nrp == 1)
            {
                Console.WriteLine("Problema " + nrp);
                p1();
            }
            if (nrp == 2)
            {
                Console.WriteLine("Problema " + nrp);
                p2();
            }
            if (nrp == 3)
            {
                Console.WriteLine("Problema " + nrp);
                p3();
            }
            if (nrp == 4)
            {
                Console.WriteLine("Problema " + nrp);
                p4();
            }
            if (nrp == 5)
            {
                Console.WriteLine("Problema " + nrp);
                p5();
            }
            if (nrp == 6)
            {
                Console.WriteLine("Problema " + nrp);
                p6();
            }
            if (nrp == 7)
            {
                Console.WriteLine("Problema " + nrp);
                p7();
            }
            if (nrp == 8)
            {
                Console.WriteLine("Problema " + nrp);
                p8();
            }
            if (nrp == 9)
            {
                Console.WriteLine("Problema " + nrp);
               p9();
            }
            if (nrp == 10)
            {
                Console.WriteLine("Problema " + nrp);
                p10();
            }
            if (nrp == 11)
            {
                Console.WriteLine("Problema " + nrp);
                p11();
            }
            if (nrp == 12)
            {
                Console.WriteLine("Problema " + nrp);
                p12();
            }
            if (nrp == 13)
            {
                Console.WriteLine("Problema " + nrp);
                p13();
            }
            if (nrp == 14)
            {
                Console.WriteLine("Problema " + nrp);
                p14();
            }
            if (nrp == 15)
            {
                Console.WriteLine("Problema " + nrp);
                p15();
            }
            if (nrp == 16)
            {
                Console.WriteLine("Problema " + nrp);
                p16();
            }
            if (nrp == 17)
            {
                Console.WriteLine("Problema " + nrp);
                p17();
            }
            if (nrp == 18)
            {
                Console.WriteLine("Problema " + nrp);
                p18();
            }
            if (nrp == 19)
            {
                Console.WriteLine("Problema " + nrp);
                p19();
            }
            if (nrp == 20)
            {
                Console.WriteLine("Problema " + nrp);
                p20();
            }
            if (nrp == 21)
            {
                Console.WriteLine("Problema " + nrp);
                p21();
            }
            Console.ReadKey();
        }
    }
}
