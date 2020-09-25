using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hoc_s_shap
{
    class bai11_ham
    {

        #region vd 1 hàm đơn giản không chả về
   /*    static void don_gian() // nhớ có static để hàm Main có thể gọi lại được
        {
            Console.WriteLine("nguyen van luc");
        } */

        #endregion

        #region vd 2 hàm có kiểu trả về
       static  bool kiem_tra(int n)
        {
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

      
        #endregion
        static void Main(string[] args)
        {
            // don_gian();

            
            
            Console.Write("nhap vao gia tri de kiem tra:");
            string n= Console.ReadLine();
            int a = Convert.ToInt32(n);

            
            if (kiem_tra(a) == true)
            {
                Console.WriteLine("so nay la so nguyen to");
            }
            else
            {
                Console.WriteLine("khong la so nguyen to");
            }
        }
    }
}
