using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai_16_mang_nhieu_chieu
    {
        /* mảng 3 chiều  (2,3,4)  số 4 thể hiện só lượng phần tử trong cùng
                                  số 3 thể hiện hai lần có số  3
                                  số 2 thể hiện hai lần có số 2 */
        #region VD mảng 3 chiều 
        /*    static void Main(string[] args)
            {
                int[,,] mang_3_chieu = new int[2, 3, 4]

                {
                {{1,2,3,4},
                {3,4,5,6},
                {4,5,6,7} },

                {{1,2,3,4},
                {3,4,5,6},
                {4,5,6,7} }
                };
                Console.WriteLine("so chieu cau mang tren la:{0}",mang_3_chieu.Rank);
                for(int i = 0; i < mang_3_chieu.GetLength(0); i++)
                {
                    for(int j = 0; j < mang_3_chieu.GetLength(1); j++)
                    {
                        for(int l = 0; l < mang_3_chieu.GetLength(2); l++)
                        {
                            Console.Write(mang_3_chieu[i, j, l]);

                        }
                        Console.WriteLine();
                    }
                   Console.WriteLine();
                }


            }  */
        #endregion
        #region VD mảng dích zắc
        /*   static void Main(string[] args)
           {
               // chỉ được khởi tạo cho chiều thứu nhất hoắc khởi tạo luân phần tử cho mảng
               int[][] mang_dich_zac1 = new int[4][];  
               // khai báo từ từ số lượng phần tử của các dòng
               mang_dich_zac1[0] = new int[3];  
               mang_dich_zac1[1] = new int[5];    // không gán phần tử mặc định là số 0
               mang_dich_zac1[2] = new int[6];
               mang_dich_zac1[3] = new int[3];
               for(int i = 0; i < mang_dich_zac1.Length; i++)
               {
                   for(int j = 0; j < mang_dich_zac1[i].Length; j++)
                   {
                       Console.Write(mang_dich_zac1[i][j]);
                   }
                   Console.WriteLine();
               }

               // hoặc
          /*     int[][] mang_dich_zac2 =  // khởi tạo luân phần tử
               {
                   new int[]{1,2,3},
                   new int[]{1,2,3},
                   new int[]{2,3},   // mảng đang đủ tự nhiên thiếu
                   new int[]{1,2,3,4,5,6}    // mảng đang đủ tự nhiên thừa
               };
               for(int i = 0; i < mang_dich_zac2.Length; i++)
               {
                   for(int j = 0; j < mang_dich_zac2[i].Length; j++)
                   {
                       Console.Write(mang_dich_zac2[i][j]);
                   }
                   Console.WriteLine();
               }  

           }  
          */
        #endregion


        // các phương thức trong lớp mảng
        static void Main(string[] AssemblyLoadEventArgs)
        {
            int[] a = { 1, 2, 34, 4, 5, 67 };
            //Array.Reverse(a);
            //   for(int i = 0; i < a.GetLength(0); i++)
            //{
            //    Console.Write(" {0}",a[i]);
            //}
            Array.Sort(a);//sắp xếp
            Array.IndexOf(a, 5);////tim phan tu o vi tri may trong mang
            Array.BinarySearch(a, 5);  // tìm phần tử trong mang
            Array.Clear(a, 0, a.Length);  // xóa tất phần tử của mảng  (ten,vị trí bắt đầu xóa,độ dài tính từ vị trí bắt đầu)
       
        }

    }
}
