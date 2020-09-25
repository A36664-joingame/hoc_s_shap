using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class UCLN_va_BCNN
    {static float  kiem_tra(int a, int b)
        {
            float tich = a * b;
            if(a!=0 && b != 0)
            { 
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                    
                }
            }
            return a;
          

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("moi ban nhap hai so a,b:");
            Console.Write("nhap a:");
            string a = Console.ReadLine();
            Console.Write("nhao b:");
            string b = Console.ReadLine();
            float tich = Convert.ToInt32(a) * Convert.ToInt32(b);
            Console.WriteLine("UCLN={0},BCNN={1}",kiem_tra(Convert.ToInt32(a), Convert.ToInt32(b)),tich/ kiem_tra(Convert.ToInt32(a), Convert.ToInt32(b)));

        }
    }
}
