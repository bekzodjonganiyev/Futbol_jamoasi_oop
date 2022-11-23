// using System;

// namespace C_
// {
//     class Topshiriq_1
//     {
//         public static void Topshiriq1()
//         {
//             try
//             {
//                 Console.Write("4 xonali son kiriting:n=");
//                 int n = int.Parse(Console.ReadLine());
//                 while (n < 1000 || n > 9999)
//                 {
//                     Console.Write("4 xonali son kiriting:n=");
//                     n = int.Parse(Console.ReadLine());
//                 }
//                 int a, b, c, d;
//                 a = n / 1000;
//                 d = n % 10;
//                 b = (n - a * 1000) / 100;
//                 c = (n - a * 1000 - b * 100) / 10;
//                 Console.WriteLine($"{a}\n{b}\n{c}\n{d}");
//                 int p = a * b * c * d;
//                 Console.WriteLine("p=" + p);
//             }
//             catch (Exception e)
//             {
//                 Console.WriteLine("son kiriting");
//             }

//         }
//     }
// }
