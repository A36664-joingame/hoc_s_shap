using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    
    class nhap_xuat_sap_xep_duongCheoCHinh
    {
        static void nhap(int[,] a)
        {
            Random ten = new Random();
           for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = ten.Next(1, 10);
                }
            }
        }
        static void xuat(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void swap(ref int a,ref int b)
        {
            int temp ;
            temp = a;
            a = b;
            b = temp;
        }
        static void kiem_tra(int[,] a)
        {
            // ta sẽ làm nó duyệt từ cuối về đầu
            int k = 0;
            while (k < a.GetLength(1))  // a.Get nào cũng được  nó chỉ là cái điều kiện dừng thôi
            {
                int i = a.GetLength(0)-1;  //cho chạy từ đầu về và trừ 1 để  mảng bắt đầu từ 0 còn độ dài bắt đầu từ 1 lên tự nghĩ đi

                int j = a.GetLength(1)-1;
                
                while (j > k)    // hãy nhớ ta đang đảo chỉ là một đường thôi và độ dài của nó cũng chỉ không quá độ dài của hàng hoặc cột
                {
                    if (a[i,j] > a[i - 1, j - 1])
                    {
                        swap(ref a[i, j], ref a[i - 1, j - 1]);

                    }   // nếu chỉ có vòng trong vẫn đổi được nhưng có trường hợp
                        //số lớn nhất đứng ở giữa nó sẽ được chuyển lên trên nhưng các số sau nó không
                        // sắp xếp nữa vì nó chỉ chạy qua đúng 1 lượt muốn quay lại tìm và duyệt tiếp thì phải 
                        // có vòng tiếp theo 


                    i--;      // phải giảm hoặc tăng cùng nhau
                    j--;
                }
                k++;

            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];
            nhap(a);
            xuat(a);
            kiem_tra(a);
            Console.WriteLine();
            xuat(a);
            //Console.WriteLine(a.GetLength(0));
            //Console.WriteLine(a.GetLength(1));

        }
    }
}
