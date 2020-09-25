using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai9_random
    {
        static void Main(string[] args)
        {
            Random ten = new Random();
            for (int i = 0; i < 5; i++)
            {
                int bien = ten.Next(1, 10);  // khoảng random
               
                
                Console.WriteLine(bien);
            }
        }
    }
}
