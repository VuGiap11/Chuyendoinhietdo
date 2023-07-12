using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace chuyennhietdo
{
    internal class Program
    {   static void Main(string[] args)
        {
            int choice;
            double F;
            double C;

            do
            {
                Console.WriteLine(" bang chuyen doi nhiet do ");
                Console.WriteLine(" 1.F to C ");
                Console.WriteLine(" 2.C to F ");
                Console.WriteLine("0.Exit ");
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(" moi nhap nhiet do F can doi : ");
                        F = double.Parse(Console.ReadLine());
                        Console.WriteLine("FtoC: " + FtoC(F));

                        break;

                    case 2:
                        Console.WriteLine(" moi nhap nhiet do F can doi : ");
                        C = double.Parse(Console.ReadLine());
                        Console.WriteLine("CtoF: " + CtoF(C));

                        break;
                    case 0:
                        Environment.Exit(0);

                        break;

                }

            } while (choice != 0);
        }
        public static  double CtoF (double C)
        {
            double F = (9.0 / 5) * C + 32;
            return F;
        }
        public static double FtoC(double F)
        {
            double C = (5.0 / 9) * (F - 32);
            return C;   
        }
    }
}
