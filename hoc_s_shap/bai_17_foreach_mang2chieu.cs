using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai_17_foreach_mang2chieu
    {
        static void Main(string[] args)
        {

            // foreach trong c# dùng cho danh sách không biết số lượng phần tử

            //     không duyệt mảng qua số lượng phần tử , tuần tự các phần tử trong mảng ,chỉ duyệt mảng hoặc tập hợp
            // đếm tuần tự không quay lại được
            // không thay đổi được biến tạm
            #region VD foreach với mảng một chiều
            //int[]a = { 1, 2, 3, 4 };
            //foreach (kiểu bien_tam in tên_mang)
            //{
            //    Console.Write(bien_tam); // ta chỉ cần xuất ra biến tạm vì biến tạm đã được mang giá trị của mảng nhưng không thể thay đổi được nhe

            //}
            #endregion
            #region VD foreach với mảng zích zắc
            int[][] a = new int[3][];

            a[0] = new int[4];
            a[1] = new int[3];
            a[2] = new int[5];

            
            foreach(int[] ten_bien_tam in a){
                foreach(int ten_bien_tam2 in  ten_bien_tam)
                {
                    Console.Write(ten_bien_tam2);
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
