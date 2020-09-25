using System;
using System.Collections.Generic;
using System.Text;
                                                               // giống như template trong c++
// một sô generic :
/*
 * list<T>
 * dictionary<Tkey,Tvalue>
 * sortedictionary<Tkey,Tvalue>
 * stack<T>
 * queue<T>
 */


namespace hoc_s_shap { 
#region class dùng generic

                                                                    // chưa xác định kiểu
 public   class student<T, X>                                          
    {
        private T name;
        private X tuoi;
        private T gioi_tinh;

        /// tự viết tiếp nếu muốn  đây là chỉ dả sử dùng kiểu này thôi
    }
    #endregion

    class bai_29_generic
    {
        #region vd generic đối với phương thức đơn lẻ
        /*  public static void swap<T>(ref T a, ref T b)
          {
              T temp = a;
              a = b;
              b = temp;

          }
          static void Main(string[] args)
          {
           int a = 5;
              int b = 6;
              Console.Write("{0},{1}",a, b);
              swap<int>(ref a,  ref b);
              Console.Write("\n{0},{1}", a, b);



          }   */
        #endregion

    }


}
