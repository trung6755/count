using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1; //khai bao chuoi ban dau
            

            Console.Write("\nDem so lan xuat hien cua chuoi con trong C#:\n");
            Console.Write("---------------------------------------------\n");

            Console.Write("Nhap chuoi ban dau: ");
            str1 = Console.ReadLine();

            count(str1);

            Console.ReadKey();
        }

        static int count(string str)
        {
            string chuoi_con;
            int strt = 0;
            int cnt = -1;
            int idx = -1;
            Console.Write("Nhap chuoi con can tim: ");
            chuoi_con = Console.ReadLine();


            while (strt != -1)
            {
                strt = str.IndexOf(chuoi_con, idx + 1);
                cnt += 1;
                idx = strt;
            }
            Console.Write("Chuoi con '{0}' xuat hien " + cnt + " lan.\n", chuoi_con);

            return cnt;
        }
    }
}
