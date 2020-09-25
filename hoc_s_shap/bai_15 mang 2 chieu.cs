using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai_15_mang_2_chieu
    {
        static void Main(string[] args)
        {
            int[,] number =new int[4,5]
            {
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 }, };
            for (int i = 0; i < number.GetLength(0);i++){    //0 LÀ HEO SÔ HÀNG
                for(int j = 0; j < number.GetLength(1);j++)  //1 LÀ THEO SỐ CỘT
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(number[i, j]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            
        }
    }
}
