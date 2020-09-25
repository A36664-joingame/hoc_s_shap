using System;
using System.Collections.Generic;
using System.Text;


namespace hoc_s_shap
{
    class bai_14_static
    {
        #region VD hàm nhập xuất mảng cơ bản
        static void nhap( string[] a)
        {for (int i = 0; i < a.Length;i++) {
                Console.Write("\nnhap phan tu thi ={0}:", i + 1);
                a[i] = Console.ReadLine();
            }
        }
        static void xuat( string[] a)
        {
            for (int j = 0; j < a.Length; j ++)
            {
                Console.WriteLine("phan tu thu ={0},{1}", j, a[j]);
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region VD về mảng cấp phát số lượng phần tử và cấp thẳng phần tử 
            //// kiểu khai báo só lượng phàn tử
            //string[] chuoi_sv=new string[100];
            //int[] age = new int[30];    
            //// kiểu khai báo luân số lượng phần tử
            //int[] so = { 1, 2, 3, 4, 5 };
            //char[] thing = { 'n', 'g', 'k', 'h' };
            //string[] vat = { "nguyen", "van", "luc" };

            //for(int i = 0; i < so.Length; i++)
            //{
            //    Console.WriteLine("so={0},vi_tri={1}", so[i], i );
            //}
            //for (int j = 0; j < vat.Length; j++)
            //{
            //    Console.Write("\nphan tu cua mang thu {0}={1}",j, vat[j]);
            //}
            #endregion

            //string[] a=new string[5];


            //nhap(a);
            //xuat(a);


                
        }
    }
}
